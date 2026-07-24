# Consuming and Creating SOAP Services

This project demonstrates how to build and expose a SOAP (Simple Object Access Protocol) web service in ASP.NET Core (.NET 8.0) using the `SoapCore` middleware.

---

## Project Structure

- **`Contracts/ICalculatorService.cs`**: The service contract interface decorated with WCF attributes (`[ServiceContract]` and `[OperationContract]`).
- **`Services/CalculatorService.cs`**: The concrete class implementing the service contract logic (e.g., the `Add` operation).
- **`Program.cs`**: Registers dependencies and maps the SOAP middleware to the `/CalculatorService.asmx` path.

---

## Setup & Running the Project

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### 1. Restore & Build the Project
Open a terminal in the project directory (`Code/SoapServiceDemo`) and run:
```bash
dotnet build
```

### 2. Run the Server
If the default port `5000` is already in use by another application, run Kestrel on a custom port (such as `5123`):
```bash
dotnet run --urls "http://localhost:5123"
```

---

## Active Endpoints

Once the application is running, the following endpoints are available:

| Endpoint | URL | Description |
|---|---|---|
| **Root Welcome Page** | `http://localhost:5123/` | Returns a simple welcome string (`SOAP Service Demo`) |
| **SOAP Service Info** | `http://localhost:5123/CalculatorService.asmx` | Displays the service contract structure and methods |
| **WSDL Document** | `http://localhost:5123/CalculatorService.asmx?wsdl` | Exposes the service metadata XML for client consumption |

---

## How to Test the SOAP Endpoint

You can test the SOAP endpoint by sending a standard XML POST request.

### Testing via PowerShell
Run the following script to send a SOAP envelope adding `10` and `20`:

```powershell
# Define the SOAP Envelope
$soapEnvelope = @"
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/">
   <soapenv:Header/>
   <soapenv:Body>
      <tem:Add>
         <tem:a>10</tem:a>
         <tem:b>20</tem:b>
      </tem:Add>
   </soapenv:Body>
</soapenv:Envelope>
"@

# Send the request to the SOAP endpoint
$response = Invoke-WebRequest -Uri "http://localhost:5123/CalculatorService.asmx" `
                           -Method Post `
                           -ContentType "text/xml;charset=UTF-8" `
                           -Body $soapEnvelope

# Output response contents
$response.Content
```

### Expected Output
The server will respond with the calculated sum (`30`) wrapped in a SOAP envelope:
```xml
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <s:Body>
    <AddResponse xmlns="http://tempuri.org/">
      <AddResult>30</AddResult>
    </AddResponse>
  </s:Body>
</s:Envelope>
```

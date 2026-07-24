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

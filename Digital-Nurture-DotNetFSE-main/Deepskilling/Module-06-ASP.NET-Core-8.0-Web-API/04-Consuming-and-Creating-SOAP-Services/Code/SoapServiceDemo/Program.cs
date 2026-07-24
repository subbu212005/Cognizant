using SoapCore;

var builder=WebApplication.CreateBuilder(args);

// Register SoapCore and the service implementation
builder.Services.AddSoapCore();
builder.Services.AddSingleton<ICalculatorService, CalculatorService>();

var app=builder.Build();

// Configure the SoapCore endpoint
app.UseSoapEndpoint<ICalculatorService>("/CalculatorService.asmx", new SoapEncoderOptions());

app.MapGet("/",()=> "SOAP Service Demo");
app.Run();
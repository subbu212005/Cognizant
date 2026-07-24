var builder = WebApplication.CreateBuilder(args);

// Add health check services
builder.Services.AddHealthChecks();

var app = builder.Build();

// Map default root route to prevent 404
app.MapGet("/", () => "Welcome to Health Checks Demo API! Access the health check endpoint at /health");

// Map health check endpoint
app.MapHealthChecks("/health");

app.Run();
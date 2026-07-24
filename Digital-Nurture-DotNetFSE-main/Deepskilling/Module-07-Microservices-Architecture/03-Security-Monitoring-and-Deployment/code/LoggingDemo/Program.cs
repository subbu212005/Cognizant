var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

app.MapGet("/", (ILogger<Program> logger) =>
{
    logger.LogInformation("Logging demo endpoint was requested.");
    return Results.Text("Logging demo is running. Check the terminal output for the log message.");
});

app.Run();
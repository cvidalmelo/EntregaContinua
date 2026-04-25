var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola Mundo desde .NET en Docker, github actions y Render!");

app.Run();
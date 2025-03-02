var builder = WebApplication.CreateBuilder(args);

// Force ASP.NET Core to listen on port 5000
builder.WebHost.UseUrls("http://+:5000");

var app = builder.Build();
app.MapGet("/", () => "Hello from .NET API!");
app.Run();

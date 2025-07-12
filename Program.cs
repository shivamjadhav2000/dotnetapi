var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Use custom request logging middleware
app.UseMiddleware<test.Middleware.RequestLoggingMiddleware>();

// Enable routing and map controllers

app.MapControllers();

app.Run();

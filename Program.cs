using NETCoreAPIWithTestableMiddleware;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

Startup startup = new(configuration);
// Add services to the container.
startup.ConfigureServices(builder.Services);
var app = builder.Build();

// Configure the HTTP request pipeline.
startup.Configure(app, app.Environment);
app.MapControllers();

app.Run();

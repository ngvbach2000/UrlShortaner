using CleanArchitecture.Web.Infrastructure;
using UrlShortaner.API;
using UrlShortaner.Infratructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationServices();
builder.Services.AddHealthChecks();
builder.Services.AddOpenApiDocument();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseOpenApi();
app.UseSwaggerUi(settings =>
{
    settings.Path = "/api";
    // settings.DocumentPath = "/api/specification.json";
});

app.UseHttpsRedirection();
app.UseHealthChecks("/health");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.UseAuthorization();

app.UseExceptionHandler(options => { });

app.Map("/", () => Results.Redirect("/api"));

app.MapControllers();
app.MapEndpoints();

app.Run();
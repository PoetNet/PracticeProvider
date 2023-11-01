var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddTextFile("config.txt");
builder.Configuration.AddJsonFile("appsettings.json");

var logs = builder.Configuration.GetSection("Logging");

var app = builder.Build();

string defaultogLogLevel = logs["LogLevel:Default"];
string microsoftAspNetCoreLogLevel = logs["LogLevel:Microsoft.AspNetCore"];

app.Map("/", (HttpContext context, IConfiguration appConfig) => 
{
    context.Response.WriteAsync($"{defaultogLogLevel} - {microsoftAspNetCoreLogLevel} \n{appConfig["name"]} - {appConfig["age"]} - {appConfig["profession"]} - {appConfig["mude"]}!");
});

app.Run();

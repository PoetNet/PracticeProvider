var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Configuration.AddTextFile("config.txt");


app.Map("/", (IConfiguration appConfig) => $"{appConfig["name"]} - {appConfig["age"]} - {appConfig["profession"]} - {appConfig["mude"]}!");

app.Run();

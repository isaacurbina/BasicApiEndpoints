var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Root Path");
app.MapGet("/downloads", () => "Downloads");
app.MapPut("/", () => "This is a PUT");
app.MapDelete("/", () => "DELETE!!!");
app.MapPost("/", () => "Post me");

app.Run();

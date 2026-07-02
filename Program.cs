var builder = WebApplication.CreateBuilder(args);

// Register MVC controller services
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

// Ensure endpoints are mapped after AddControllers
app.MapControllers();

app.MapGet("/", () => "Root Path");
app.MapGet("/downloads", () => "Downloads");
app.MapPut("/", () => "This is a PUT");
app.MapDelete("/", () => "DELETE!!!");
app.MapPost("/", () => "Post me");

app.Run();

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
var services = builder.Services;

services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddScoped(_ => config)
    .AddHttpContextAccessor()
    .AddDbContext<DatabaseContext>(options => options.UseCosmos("connectionString", "databaseName"))
    .AddScoped<ITodoService, TodoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapFallbackToFile("index.html");

var apiGroup = app.MapGroup("api");

apiGroup.MapTodoEndpoints();

app.Run();

using Todo_Cosmos_Db_Test.Server.Endpoints;

var builder = WebApplication.CreateBuilder(args);

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

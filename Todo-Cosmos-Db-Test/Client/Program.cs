var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var services = builder.Services;
const string serverApiClientName = "Todo_Cosmos_Db_Test.ServerAPI";

services.AddHttpClient(serverApiClientName, client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient(serverApiClientName));

await builder.Build().RunAsync();

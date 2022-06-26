using BlazorAppMonkeyList;
using BlazorAppMonkeyList.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient(nameof(MonkeyService), client => client.BaseAddress = new Uri("https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/"));

builder.Services.AddScoped<IMonkeyService, MonkeyService>();

await builder.Build().RunAsync();

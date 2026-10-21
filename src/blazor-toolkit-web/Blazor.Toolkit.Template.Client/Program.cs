using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor.Toolkit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSyncfusionBlazorToolkit(); 
await builder.Build().RunAsync();

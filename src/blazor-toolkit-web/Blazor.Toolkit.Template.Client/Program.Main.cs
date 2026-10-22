using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor.Toolkit;
namespace Blazor.Toolkit.Template.Client;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.Services.AddSyncfusionBlazorToolkit();
        await builder.Build().RunAsync();
    }
}

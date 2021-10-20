using System;
using System.Net.Http;
using System.Threading.Tasks;
using Congo.Contracts.Clients;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Refit;

namespace Congo.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMudServices();

            var congoApiUri = new Uri("https://localhost:44388");

            builder.Services.AddRefitClient<ICongoSellerClient>()
                .ConfigureHttpClient(x => x.BaseAddress = congoApiUri);

            await builder.Build().RunAsync();
        }
    }
}

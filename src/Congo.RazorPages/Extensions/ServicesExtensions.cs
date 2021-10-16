using System;
using Congo.Contracts.Clients;
using Congo.RazorPages.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Congo.RazorPages.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IProductsService, ProductsService>();
        }

        public static void AddHttpClients(this IServiceCollection services, IConfiguration config)
        {
            services.AddHttpClient(nameof(Congo), config =>
            {
                config.BaseAddress = new Uri("https://localhost:44388/api/");
            });

            var congoApiUri = new Uri(config["CongoApi"]);
            services.AddRefitClient<ICongoUserClient>()
                .ConfigureHttpClient(x => x.BaseAddress = congoApiUri);

            services.AddRefitClient<ICongoSellerClient>()
                .ConfigureHttpClient(x => x.BaseAddress = congoApiUri);
        }
    }
}

using System;
using Congo.Contracts.Clients;
using Congo.RazorPages.Services;
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

        public static void AddHttpClients(this IServiceCollection services)
        {
            services.AddHttpClient("Congo", config =>
            {
                config.BaseAddress = new Uri("/api");
            });

            services.AddRefitClient<ICongoUserClient>()
                .ConfigureHttpClient(x => x.BaseAddress = new Uri("https://localhost:44388"));

            services.AddRefitClient<ICongoSellerClient>()
                .ConfigureHttpClient(x => x.BaseAddress = new Uri("https://localhost:44388"));
        }
    }
}

using System;
using Congo.RazorPages.Services;
using Microsoft.Extensions.DependencyInjection;

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
                config.BaseAddress = new Uri("https://localhost:44388/");
            });
        }
    }
}

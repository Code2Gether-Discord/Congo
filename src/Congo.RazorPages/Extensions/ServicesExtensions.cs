using System;
using Congo.RazorPages.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.RazorPages.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureAppServices(this IServiceCollection services)
        {
            services.AddScoped<IProductsService, ProductsService>();
        }

        public static void ConfigureHttpClients(this IServiceCollection services)
        {
            services.AddHttpClient("Congo", config =>
            {
                config.BaseAddress = new Uri("/api");
            });
        }
    }
}

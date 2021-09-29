using Congo.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddAppServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CongoContext>(opt => opt.UseSqlServer(config.GetConnectionString("Default")));
        }
    }
}

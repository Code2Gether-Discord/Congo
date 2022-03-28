using Congo.WebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Extensions;

public static class ServicesExtensions
{
    public static void AddAppServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<CongoContext>(opt => opt.UseSqlServer(config.GetConnectionString("Default")));
    }
}
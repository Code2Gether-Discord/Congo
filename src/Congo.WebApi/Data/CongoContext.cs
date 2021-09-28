using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data
{
    public class CongoContext : DbContext
    {
        public CongoContext(DbContextOptions<CongoContext> options) : base(options)
        {
        }
    }
}

using Congo.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data
{
    public class CongoContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public CongoContext(DbContextOptions<CongoContext> options) : base(options)
        {
        }
    }
}

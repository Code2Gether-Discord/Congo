using Congo.WebApi.Data.Configurations;
using Congo.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data
{
    public class CongoContext : DbContext
    {
        public CongoContext(DbContextOptions<CongoContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());

            base.OnModelCreating(modelBuilder);
        }
    }
}

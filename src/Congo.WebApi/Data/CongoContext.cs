using Congo.WebApi.Data.Configurations;
using Congo.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CongoContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}

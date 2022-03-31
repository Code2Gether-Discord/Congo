using Congo.WebApi.Data.Models;
using Congo.WebApi.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data;

public class CongoContext : DbContext
{
    public CongoContext(DbContextOptions<CongoContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CongoContext).Assembly);
        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }

}
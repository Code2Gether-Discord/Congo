using Congo.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Congo.WebApi.Data.Configurations
{
    public class OrderItemEntityTypeConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                .HasOne<Product>()
                .WithMany();

            builder
                .Property(x => x.Price)
                .HasColumnType("decimal(19,4)")
                .IsRequired();

            builder
                .Property(x => x.Amount)
                .IsRequired();
        }
    }
}

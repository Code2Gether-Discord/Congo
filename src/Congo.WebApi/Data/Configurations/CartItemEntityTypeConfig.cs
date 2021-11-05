using Congo.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Congo.WebApi.Data.Configurations
{
    public class CartItemEntityTypeConfig : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder
                .HasOne<Cart>()
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.CartId)
                .IsRequired();

            builder
                .HasOne(x => x.Product)
                .WithMany()
                .IsRequired();
        }
    }
}

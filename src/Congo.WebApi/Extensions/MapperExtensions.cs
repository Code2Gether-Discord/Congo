using Congo.Contracts.Responses.Cart;
using Congo.WebApi.Data.Models;
using Mapster;

namespace Congo.WebApi.Extensions;

public static class MapperExtensions
{
    public static void AddPriceMappingConfig()
    {
        TypeAdapterConfig.GlobalSettings.NewConfig<CartItem, CartItemResponse>()
            .Map(dest => dest.TotalPrice, src => src.Quantity * src.Product.Price);
        TypeAdapterConfig.GlobalSettings.NewConfig<Cart, CartResponse>()
            .Map(dest => dest.TotalPrice, src => src.CartItems.Sum(i => i.Product.Price * i.Quantity));
    }
}
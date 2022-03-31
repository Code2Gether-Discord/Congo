using System;
using System.Threading.Tasks;
using Congo.Contracts.Requests.Products;
using Refit;

namespace Congo.Contracts.Clients;

public interface ICongoSellerClient
{
    [Post("/api/SellerProducts/products")]
    Task<ApiResponse<Guid>> CreateProduct(InsertProductRequest product);
}

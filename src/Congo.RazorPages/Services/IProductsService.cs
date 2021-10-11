using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.RazorPages.Models;

namespace Congo.RazorPages.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetProducts();
        IEnumerable<Product> GetSampleProducts();
        Task<Guid> Purchase(Guid productId);
    }
}

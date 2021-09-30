using Congo.WebApi.Data.Models;
using System.Collections.Generic;

namespace Congo.WebApi.DataAccess
{
    public interface IDemoProductDataAccess
    {
        List<Product> GetProducts();
        Product InsertProduct(string name, string description, decimal price, string url);
    }
}
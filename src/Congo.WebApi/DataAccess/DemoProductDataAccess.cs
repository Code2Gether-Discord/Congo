using Congo.WebApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.WebApi.DataAccess
{
    public class DemoProductDataAccess : IDemoProductDataAccess
    {
        //Demo DataBase for example purposes
        private List<Product> products = new();
        public DemoProductDataAccess()
        {
            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Congo-Brand Headphones",
                Description = "The awesome new headphones!",
                Price = 25.00m,
                ImageUrl = "https://images.unsplash.com/photo-1484704849700-f032a568e944?ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8aGVhZHBob25lc3xlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&w=1000&q=80"
            });
            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Congo-Brand Socks",
                Description = "The awesome new socks!",
                Price = 5.00m,
                ImageUrl = "https://media.4rgos.it/i/Argos/tuc133326346-White_R_Z001A?w=598&h=810&qlt=70"
            });
        }

        public List<Product> GetProducts()
        {
            return products;
        }
        public Product InsertProduct(string name, string description, decimal price, string url)
        {
            Product p = new() { Id = Guid.NewGuid(), Name = name, Description = description, Price = price, ImageUrl = url };
            products.Add(p);
            return p;
        }
    }

}

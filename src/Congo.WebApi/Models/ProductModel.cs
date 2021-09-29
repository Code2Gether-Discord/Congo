using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.WebApi.Models
{
    public class ProductModel
    {
        public string Name{ get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImgUri { get; set; }
    }
}

using MVCCoreApp.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCoreApp.Service
{
    public class ProductService : IProductService
    {
        public List<ProductDTO> GetAll()
        {
            return new List<ProductDTO>()
            {
                new ProductDTO {ID = 1, Name = "Pro1"},
                new ProductDTO {ID = 2, Name = "Pro2"},
                new ProductDTO {ID = 3, Name = "Pro3"}
            };
        }
    }
}

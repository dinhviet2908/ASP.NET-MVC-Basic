using MVCCoreApp.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCoreApp.Service
{
    public interface IProductService
    {
        List<ProductDTO> GetAll();
    }
}

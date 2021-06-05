using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        public List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel(){
                Id = 1,
                Available = true,
                Name = "Pro1",
                Price = 10000,
                PromotionPrice = 8000
            },
            new ProductModel(){
                Id = 2,
                Available = false,
                Name = "Pro12",
                Price = 20000,
                PromotionPrice = 18000
            }
        };
        public IActionResult Index()
        {
            return View(products);
        }
        //Fail: http://localhost:port/product/edit
        //Ok: http://localhost:port/product/modify
        //[ActionName("Modify")] // ~~ [Route("Product/Modify")]
        //[NonAction]

        [HttpGet]
        public string Edit(string id)
        {
            return "From edit method";
        }

        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            return RedirectToAction("Index","Product");
        }
    }
}

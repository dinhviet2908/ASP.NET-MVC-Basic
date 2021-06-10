using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;
using MVCCoreApp.Models.Product;
using MVCCoreApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        //không dùng DI
        //private readonly ProductService _productService;
        //public ProductController()
        //{
        //    _productService = new ProductService();
        //}

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

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

        //[HttpGet]
        //public string Edit(string id)
        //{
        //    return "From edit method";
        //}

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            var model = new ProductEditModel()
            {
                Name = "Test"
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                if (model.Name == "test")
                {
                    ModelState.AddModelError("", "This name was exists!");
                    return View(model);
                }
                message = "Product: " + model.Name + ". Rate: " + model.Rate + ". Rating: " + model.Rating + " created!";
            }
            else return View(model);
            return Content(message);
        }

        [HttpPost]
        public IActionResult NoModelBinding()
        {
            var model = new ProductEditModel();
            string message = "";

            model.Name = Request.Form["Name"].ToString();
            model.Rate = Convert.ToDecimal(Request.Form["Rate"]);
            model.Rating = Convert.ToInt32(Request.Form["Rating"]);

            message = "product " + model.Name + " created!";
            return Content(message);
        }

        [HttpGet]
        public IActionResult FormAndQuery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormAndQuery([FromQuery] string name, ProductEditModel productEditModel)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Query: " + name + "Product: " + productEditModel.Name + ". Rate: " + productEditModel.Rate + ". Rating: " + productEditModel.Rating + " created!";
            }
            else message = "Failed to create product!";
            return Content(message);
        }

    }
}

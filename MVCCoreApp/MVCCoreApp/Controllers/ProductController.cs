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

        public IActionResult Index()
        {
            return View();
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

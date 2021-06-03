using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/Index/{id:int}")]
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "Hello model with Id = " + id;
            return View(model);
        }
    }
}

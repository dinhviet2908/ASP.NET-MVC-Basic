using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        //[Route("Home/Index/{id:int}")]
        //public IActionResult Index(int id)
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello model with Id = " + id;
        //    return View(model);
        //}

        public IActionResult Index()
        {
            ViewData["Greeting"] = "Hello world";
            ViewData["IndexModel"] = new IndexModel() {
                Message = "Say hello"
            };

            ViewBag.SayGoodbye = "Goodbye";
            return View();
        }

        //HttpContext ctx;
        //public HomeController(IHttpContextAccessor _ctx)
        //{
        //    ctx = _ctx.HttpContext;
        //}
        //public async void Index()
        //{
        //    ctx.Response.StatusCode = 200;
        //    ctx.Response.ContentType = "text/html";
        //    ctx.Response.Headers.Add("SomeHeader", "Value");
        //    byte[] content = Encoding.ASCII.GetBytes("<html><body>Hello World</html></body>");
        //    await ctx.Response.Body.WriteAsync(content, 0, content.le);
        //}
    }
}

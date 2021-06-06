using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Controllers
{
    public class CustomerController : Controller
    {
        //[Route("Customer/Customer1")]
        //public string Customer1()
        //{
        //    return "Customer1";
        //}

        ////[Route("")]
        //[Route("Customer/Customer2")]
        //public string Customer2()
        //{
        //    return "Customer2";
        //}

        public IActionResult Index()
        {
            //ViewBag.Customer = new Customer();
            var customer = new Customer();
            return View(customer);
        }
    }
}

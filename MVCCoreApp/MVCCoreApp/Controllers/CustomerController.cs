using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Controllers
{
    public class CustomerController : Controller
    {
        [Route("Customer/Customer1")]
        public string Customer1()
        {
            return "Customer1";
        }

        //[Route("")]
        [Route("Customer/Customer2")]
        public string Customer2()
        {
            return "Customer2";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class ProductAdd : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Food()
        {
            return View();
        }
        public IActionResult Price()
        {
            return View();
        }
    }
}

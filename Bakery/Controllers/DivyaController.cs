﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class DivyaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

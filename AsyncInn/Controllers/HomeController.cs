﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// returns index view to controller
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MVC_EF_Start

{
    public class HomeController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult BeersIndex2()
        {
            return View();
        }
        public IActionResult Beers()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Indian()
        {
            return View();
        }
        public IActionResult Japanese()
        {
            return View();
        }
        public IActionResult Mexican()
        {
            return View();
        }
    }
}

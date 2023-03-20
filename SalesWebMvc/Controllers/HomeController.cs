using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Salles Web MVC App From C# Course";
            ViewData["professor"] = "Nelio Alves";
            ViewData["emailprofessor"] = "nelio@gmail.com";
            ViewData["student"] = "Paulo Stefam Viana";
            ViewData["emailstudent"] = "pauloviana_poty@hotmail.com";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

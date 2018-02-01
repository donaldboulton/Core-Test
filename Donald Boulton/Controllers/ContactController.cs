using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Donald_Boulton.Models;

namespace Donald_Boulton.Controllers
{
    public class ContactController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact";

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Privacy";

            return View();
        }

        public IActionResult Terms()
        {
            ViewData["Message"] = "Terms";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

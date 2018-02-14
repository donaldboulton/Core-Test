using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mansbooks.Models;

namespace Mansbooks.Controllers
{
    public class ContactController : Controller
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

        public IActionResult Search()
        {
            ViewData["Message"] = "Search";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

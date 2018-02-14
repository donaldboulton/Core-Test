using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mansbooks.Models;

namespace Mansbooks.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Letter_Avatar()
        {
            ViewData["Message"] = "Letter Avatar";

            return View();
        }

        public IActionResult Windows_Tweaks()
        {
            ViewData["Message"] = "Windows Tweaks";

            return View();
        }

        public IActionResult Website_Performance()
        {
            ViewData["Message"] = "Website Performance";

            return View();
        }

        public IActionResult Sql_Defrag()
        {
            ViewData["Message"] = "SQL Defrag";

            return View();
        }

        public IActionResult Check_Fragmentation()
        {
            ViewData["Message"] = "Check Fragmentation";

            return View();
        }

        public IActionResult SQL_Session_State()
        {
            ViewData["Message"] = "SQL Session State";

            return View();
        }

        public IActionResult Mobile_Colorbox()
        {
            ViewData["Message"] = "Mobile Colorbox";
            return View();
        }

        public IActionResult Social_Sharing()
        {
            ViewData["Message"] = "Social Sharing";
            return View();
        }

        public IActionResult AWS_Free_tier()
        {
            ViewData["Message"] = "AWS Free Tier";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

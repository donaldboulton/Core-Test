using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;

namespace Donald_Boulton.FormController
{
    public class FormController : Controller
    {
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(FormModel model)
        {
            return Content($"Hello {model.Name}");
        }

        private IActionResult Content(string v)
        {
            throw new NotImplementedException();
        }
    }
    public class FormModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }
    }
    public class Controller
    {
    }
}

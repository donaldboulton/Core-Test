using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;

namespace Donald_Boulton.Controllers
{
    public class ContactFormController : Controller
    {
        // GET: ContactForm
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactForm/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactForm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactForm/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactForm/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactForm/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactForm/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactForm/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
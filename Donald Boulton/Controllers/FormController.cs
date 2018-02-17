using System;
using System.Net.Mail;
using System.Net.Http;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mansbooks.FormController
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

        public string ConfirmEmail { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
    public class Controller
    {
    }
    internal class SendMail
    {
        private static void Index()
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("XXXXXXXXXXXXXXXXXXX");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("*", "User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("donaldboulton@mansbooks.com", "Example User");
            var plainTextContent = "Send Mail to Donald Boulton";
            var htmlContent = "<strong>Send Mail</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}

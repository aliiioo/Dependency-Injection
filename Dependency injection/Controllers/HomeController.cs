
using Dependency_injection.Models;
using Dependency_injection.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEmailSender _emailSender;
        
        public HomeController(ILogger<HomeController> logger,Func<EmailSelector, IEmailSender> sender)
        {
            _logger = logger;
            _emailSender = sender(EmailSelector.Gmail);// Select Gmail or Yahoo
        }

        public IActionResult Index()
        {
            // in View Write From Gmail 
            ViewBag.Email=_emailSender.SendEmail();
            return View();
        }

        public IActionResult Yahoo_Sender()
        {
           // inject Service in View 
            return View();
        }



    }
}
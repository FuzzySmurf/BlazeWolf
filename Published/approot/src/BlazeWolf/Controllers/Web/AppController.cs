using System;
using BlazeWolf.Services;
using BlazeWolf.ViewModels;
using Microsoft.AspNet.Mvc;

namespace BlazeWolf.Controllers.Web {

    public class AppController : Controller {

        private IMailService _mailService;

        public AppController(IMailService service) {
            _mailService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //Policy Page
        public IActionResult NightBearPolicy() {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model) {
            if (ModelState.IsValid) {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];
                if (string.IsNullOrWhiteSpace(email))
                    ModelState.AddModelError("","Could not send email, configuration problem");

                if (_mailService.SendMail(email, email,
                        $"Contact Page from {model.Name} ({model.Email}", model.Message)) {
                   ModelState.Clear();
                   ViewBag.Message = "Mail Sent. Thanks!";
                }
            }
            return View();
        }
    }
}
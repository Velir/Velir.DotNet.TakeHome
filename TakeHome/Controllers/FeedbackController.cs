using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Index(FeedbackForm form)
        {
            if (!ModelState.IsValid)
                return View("Index", form);

            //todo: save data

            return View("ThankYou", form);
        }
    }
}
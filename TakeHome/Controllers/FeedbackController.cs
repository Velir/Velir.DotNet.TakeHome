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
        // GET: Feedback
        
        public ActionResult Feedback()
        {
            return View();
        }

        [ValidateInput(true)]
        public ActionResult Submit(FeedbackForm form)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", form);
            }
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View("Feedback");
        }

    }
}
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
        
        public ActionResult Index()
        {
            return View("FeedBack");
        }

        public ActionResult FeedbackGoneWrong()
        {
            return View("FeedbackGoneWrong"); // but this view does not exist, so it should show error page
        }

        [ValidateInput(true)]
        [HttpPost]
        public ActionResult Feedback(FeedbackForm form)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", form);
            }
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View();
        }

    }
}
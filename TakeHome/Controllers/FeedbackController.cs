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
            return View("Feedback");
        }

        [ValidateInput(true)]
        public ActionResult Feedback(FeedbackForm form)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", form);
            }
               
            return View("Error");
        }

    }
}
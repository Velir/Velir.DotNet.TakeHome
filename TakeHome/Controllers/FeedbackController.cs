using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    /// <summary>
    /// Controller for Feedback form and related functionality.
    /// </summary>
    public class FeedbackController : Controller
    {
        /// <summary>
        /// Returns the form page directly.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(FeedbackForm form) {
            // If the form submitted sucessfully, redirect to the ThankYou page and passthrough the form data.
            return Redirect("/Feedback/Feedback");
        }

        /// <summary>
        /// Returns the Feedback (form) page.
        /// </summary>
        /// <param name="form">The form passed through to the page.</param>
        /// <returns>Return the Feedback form page. If the form is being submitted and is properly filled out, it is routed to the ThankYou page.</returns>
        [ValidateInput(true)]
        public ActionResult Feedback(FeedbackForm form)
        {
            // If the form submitted sucessfully, redirect to the ThankYou page and passthrough the form data.
            if (ModelState.IsValid)
            {
                return View("ThankYou", form);
            }
            
            
            // If the page is not in a submission state, display the form.
            return View();
        }

    }
}
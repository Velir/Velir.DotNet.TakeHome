using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    /// <summary>
    /// Controller for Error pages and related functionality.
    /// </summary>
    public class ErrorController : Controller
    {
        /// <summary>
        /// Represents the error page (500 and related codes) for the website.
        /// </summary>
        /// <param name="error"></param>
        /// <returns>Returns the content for the Error page.</returns>
        public ActionResult Error()
        {
            return View("Error");
        }

        /// <summary>
        /// Represents the NotFound (404) page.
        /// </summary>
        /// <returns></returns>
        public ActionResult NotFound()
        {
            // Set status code to 404 and skip IIS errors to display the intended URL and prevent
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View("NotFound");
        }

        /// <summary>
        /// A simple ActionResult that causes a page crash to exemplify error handling.
        /// </summary>
        /// <returns></returns>
        public ActionResult ErrorTest()
        {
            return View("ErrorTest");
        }
    }
}
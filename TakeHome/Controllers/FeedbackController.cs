using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    public class FeedbackController : Controller
    {
        [ValidateInput(true)]
        public ActionResult Feedback(FeedbackForm form)
        {
            if (ModelState.IsValid)
            {
                return View(Constants.Views.ThankYou, form);
            }
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(Constants.Views.Feedback);
        }
    }
}
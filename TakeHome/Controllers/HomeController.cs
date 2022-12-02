using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TakeHome.Controllers
{
	/// <summary>
	/// The Home controller.
	/// </summary>
	public class HomeController : Controller
	{
		/// <summary>
		/// Returns the homepage.
		/// </summary>
		/// <returns></returns>
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// Returns the Contact page.
		/// </summary>
		/// <returns></returns>
		public ActionResult Contact()
		{
			return View();
		}
	}
}
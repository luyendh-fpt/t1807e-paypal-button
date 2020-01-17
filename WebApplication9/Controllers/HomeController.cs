using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private static int ipnRequestCount = 0;

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Ipn()
        {
            ipnRequestCount++;
            ViewBag.Message = "Count ipn request. " + ipnRequestCount;
            return View("About");
        }

        public ActionResult Success()
        {
            ViewBag.Message = "Check out success.";
            return View("About");
        }

    }
}
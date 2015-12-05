using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nwt_Twitter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Profile()
        {

            return View();
        }

        public ActionResult Following()
        {

            return View();
        }

        public ActionResult Favourites()
        {

            return View();
        }
    }
}
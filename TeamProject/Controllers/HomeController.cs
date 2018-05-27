using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Message = "Your privacy policy page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult UpdatePassword()
        {
            return View();
        }

        public ActionResult AdminLogin()
        {
            return View();
        }
    }
}
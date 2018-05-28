using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProject.Controllers
{
    public class HomeController : Controller
    {

        // Get: Home page
        public ActionResult Index()
        {
            return View();
        }

        // Get: About
        public ActionResult About()
        {
            return View();
        }

        // Get: Privacy
        public ActionResult Privacy()
        {
            ViewBag.Message = "Your privacy policy page.";

            return View();
        }

        // Get: Contact
        public ActionResult Contact()
        {
            return View();
        }

        // Get: ForgotPassword
        public ActionResult ForgotPassword()
        {
            return View();
        }

        // Get: UpdatePassword
        public ActionResult UpdatePassword()
        {
            return View();
        }

        // Get: AdminLogin
        public ActionResult AdminLogin()
        {
            return View();
        }

        // Get: StudentLogin
        public ActionResult StudentLogin()
        {
            return View();
        }

        // Get: KioskLogin
        public ActionResult KioskLogin()
        {
            return View();
        }
    }
}
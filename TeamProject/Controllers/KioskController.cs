using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProject.Controllers
{
    public class KioskController : Controller
    {
        // GET: Kiosk
        public ActionResult Index()
        {
            return View();
        }

        // Get: Attendance
        public ActionResult Attendance()
        {

            return View();
        }
    }
}
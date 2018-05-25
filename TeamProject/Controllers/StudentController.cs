using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProject.Controllers
{
    public class StudentController : Controller
    {

        /***** Added Thursday 5/24 by Vic *****/
        // Call StudentView Model 
        private Models.StudentViews StudentView = new Models.StudentViews();
        /***** Added Thursday 5/24 by Vic *****/





        // GET: Student Index
        public ActionResult Dashboard()
        {
            return View();
        }


        // GET: Student Profile
        public ActionResult Profile()
        {
            return View();
        }


        // GET: Student Access to the WorldTour Game
        public ActionResult Game()
        {
            return View(StudentView);
        }


        // GET: Student Attendance Records
        public ActionResult Record()
        {
            return View();
        }


        // GET: Student Calendar
        public ActionResult Calendar()
        {
            return View();
        }

        // GET: WorldTour Select Building
        public ActionResult Select()
        {
            return View(StudentView);
        }


        // GET: WorldTour Level Seattle
        public ActionResult Play()
        {
            return View(StudentView);
        }


        // GET: WorldTour PrizeTomb
        public ActionResult PrizeTomb()
        {
            return View(StudentView);
        }


        // GET: WorldTour Prize Index
        public ActionResult PrizeDex()
        {
            return View(StudentView);
        }


        // GET: WorldTour Coin Bank
        public ActionResult CoinBank()
        {
            return View(StudentView);
        }
    }
}
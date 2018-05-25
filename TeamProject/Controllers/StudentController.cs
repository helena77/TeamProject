using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject.Models;
using TeamProject.Backend;

namespace TeamProject.Controllers
{
    // Controller for Student class
    public class StudentController : Controller
    {
        // A ViewModel used for the Student that contains the StudentList
        private StudentViewModel StudentViewModel = new StudentViewModel();

        // The Backend Data source
        private StudentBackend StudentBackend = StudentBackend.Instance;

        // GET: Student Index
        public ActionResult Dashboard()
        {
            return View();
        }


        public ActionResult Profile()
        {
            return View();
        }


        // GET: Student Access to the WorldTour Game
        public ActionResult Game()
        {
            return View();
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
            return View();
        }


        // GET: WorldTour Level Seattle
        public ActionResult Play()
        {
            return View();
        }


        // GET: WorldTour PrizeTomb
        public ActionResult PrizeTomb()
        {
            return View();
        }


        // GET: WorldTour Prize Index
        public ActionResult PrizeDex()
        {
            return View();
        }


        // GET: WorldTour Coin Bank
        public ActionResult CoinBank()
        {
            return View();
        }
    }
}
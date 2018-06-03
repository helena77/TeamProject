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

        // GET: Student Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }

        // GET: Student Profile
        public ActionResult Profile()
        {
            return View();
        }

        // GET: WorldTour Level Seattle
        public ActionResult GameInfo()
        {
            return View();
        }

        // GET: Student Access to the WorldTour Current Game
        public ActionResult Game()
        {
            return View();
        }

        // GET: Student Access to the WorldTour previous level Game
        public ActionResult Level1()
        {
            return View();
        }

        // GET: level 1 collection
        public ActionResult Collection()
        {
            return View();
        }

        // GET: Student Access to the WorldTour next level Game
        public ActionResult Level3()
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


        // GET: WorldTour Level egypt
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
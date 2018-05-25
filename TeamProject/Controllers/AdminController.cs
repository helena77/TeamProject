using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject.Models;
using TeamProject.Backend;

namespace TeamProject.Controllers
{
    public class AdminController : Controller
    {
        // A ViewModel used for the Student that contains the StudentList
        private StudentViewModel StudentViewModel = new StudentViewModel();

        // The Backend Data source
        private StudentBackend StudentBackend = StudentBackend.Instance;

        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        // GET: Student
        /// <summary>
        /// Students, the page that shows all the Students
        /// </summary>
        /// <returns></returns>
        public ActionResult Students()
        {
            // Load the list of data into the StudentList
            var myDataList = StudentBackend.Index();
            var StudentViewModel = new StudentViewModel(myDataList);
            return View(StudentViewModel);
        }

        /// <summary>
        /// Read information on a single Student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Admin/Read/
        public ActionResult Read(string id = null)
        {
            var myDataStudent = StudentBackend.Read(id);
            if (myDataStudent == null)
            {
                RedirectToAction("Error", "Home", "Invalid Record");
            }

            var myData = new StudentDisplayViewModel(myDataStudent);
            if (myData == null)
            {
                RedirectToAction("Error", "Home", "Invalid Record");
            }

            return View(myData);
        }

        /// <summary>
        /// This opens up the make a new Student screen
        /// </summary>
        /// <returns></returns>
        // GET: Admin/Create
        public ActionResult Create()
        {
            var myData = new StudentModel();
            return View(myData);
        }

        /// <summary>
        /// Make a new Student sent in by the create Admin screen
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create([Bind(Include=
                                        "Id,"+
                                        "Name,"+
                                        "PictureId,"+
                                        "Status,"+
                                        "")] StudentModel data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit
                return View(data);
            }

            if (data == null)
            {
                // Send to Error Page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Id))
            {
                // Return back for Edit
                return View(data);
            }

            StudentBackend.Create(data);

            return RedirectToAction("Students");
        }

        public ActionResult Report()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Setting()
        {
            return View();
        }
    }
}
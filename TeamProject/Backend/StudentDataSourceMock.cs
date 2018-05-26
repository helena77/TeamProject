using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject.Models;

namespace TeamProject.Backend
{
    /// <summary>
    /// Holds the Student Data as a Mock Data set, used for Unit Testing, System Testing, Offline Development etc.
    /// </summary>
    public class StudentDataSourceMock : IStudentInterface
    {
        /// <summary>
        /// Make into a singleton
        /// </summary>
        private static volatile StudentDataSourceMock instance;
        private static object syncRoot = new Object();

        private StudentDataSourceMock() { }

        public static StudentDataSourceMock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new StudentDataSourceMock();
                            instance.Initialize();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// The Data for the Students
        /// </summary>
        private List<StudentModel> StudentList = new List<StudentModel>();

        /// <summary>
        /// Makes a new Student
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Student Passed In</returns>
        public StudentModel Create(StudentModel data)
        {
            StudentList.Add(data);
            return data;
        }

        /// <summary>
        /// Return the data for the id passed in
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Null or valid data</returns>
        public StudentModel Read(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }

            var myReturn = StudentList.Find(n => n.Id == id);
            return myReturn;
        }

        /// <summary>
        /// Update all attributes to be what is passed in
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Null or updated data</returns>
        public StudentModel Update(StudentModel data)
        {
            if (data == null)
            {
                return null;
            }
            var myReturn = StudentList.Find(n => n.Id == data.Id);

            myReturn.Update(data);

            return myReturn;
        }

        /// <summary>
        /// Remove the Data item if it is in the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True for success, else false</returns>
        public bool Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                return false;
            }

            var myData = StudentList.Find(n => n.Id == Id);
            var myReturn = StudentList.Remove(myData);
            return myReturn;
        }

        /// <summary>
        /// Return the full dataset
        /// </summary>
        /// <returns>List of Students</returns>
        public List<StudentModel> Index()
        {
            return StudentList;
        }

        /// <summary>
        /// Reset the Data, and reload it
        /// </summary>
        public void Reset()
        {
            StudentList.Clear();
            Initialize();
        }

        /// <summary>
        /// Create Placeholder Initial Data
        /// </summary>
        public void Initialize()
        {
            Create(new StudentModel("Joe", "Seo", "seow@seattleu.edu", "1"));
            Create(new StudentModel("Jenny", "Moon", "moonj@seattleu.edu", "2"));
            Create(new StudentModel("Erica", "Chen", "chene@seattleu.edu", null));
            Create(new StudentModel("Helena", "Wang","wangh@seattleu.edu", null));
            Create(new StudentModel("Daniel", "Deng", "dengd@seattleu.edu", null));
            Create(new StudentModel("Victor", "Chimenti", "chimentiv@seattleu.edu", null));
            Create(new StudentModel("Kyle", "Tible", "tiblek@seattleu.edu", null));
            Create(new StudentModel("Raelee","Reiger", "reigerr@seattleu.edu", null));
            Create(new StudentModel("Cristina", "Chen", "chenc@seattleu.edu", null));
            Create(new StudentModel("Jack", "Joesph", "josephj@seattleu.edu", null));
        }
    }
}
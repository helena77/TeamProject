using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject.Models;

namespace TeamProject.Backend
{
    /// <summary>
    /// The interface for the Student DataSource.
    /// </summary>
    public interface IStudentInterface
    {
        StudentModel Create(StudentModel data);
        StudentModel Read(string id);
        StudentModel Update(StudentModel data);
        bool Delete(string id);
        List<StudentModel> Index();
        void Reset();
    }
}
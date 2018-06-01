using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TeamProject.Backend;

namespace TeamProject.Models
{
    /// <summary>
    /// The archive, that holds previous years student information including student first name, last name, school year, and graduate status
    /// </summary>
    public class ArchiveModel
    {
        /// <summary>
        /// The ID for the Student, this is the key, and a required field
        /// </summary>
        [Key]
        [Display(Name = "Id", Description = "Student Id")]
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        [Display(Name = "First Name", Description = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FName { get; set; }

        [Display(Name = "Last Name", Description = "Last Name")]
        [Required(ErrorMessage = "LAst Name is required")]
        public string LName { get; set; }

        [Display(Name = "School Year", Description = "School Year")]
        [Required(ErrorMessage = "School year is required")]
        public string SYear { get; set; }

        [Display(Name = "Grduate Status", Description = "Graduate Status")]
        [Required(ErrorMessage = "Graduate status is required")]
        public GraduateStatusEnum Status { get; set; }


        public ArchiveModel(StudentModel student, string year, GraduateStatusEnum status)
        {
            Id = student.Id;
            FName = student.Name;
            LName = student.LastName;
            SYear = year;
            Status = status;
        }

        public 
    }
}
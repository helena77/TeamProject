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


        public ArchiveModel(ArchiveModel data)
        {
            Id = data.Id;
            FName = data.FName;
            LName = data.LName;
            SYear = data.SYear;
            Status = data.Status;
        }

        public ArchiveModel(StudentModel student, string year, GraduateStatusEnum status)
        {
            Id = student.Id;
            FName = student.Name;
            LName = student.LastName;
            SYear = year;
            Status = status;
        }

        public ArchiveModel(string firstname, string lastname, string year, GraduateStatusEnum status)
        {
            Id = Guid.NewGuid().ToString();
            FName = firstname;
            LName = lastname;
            SYear = year;
            Status = status;
        }

        /// <summary>
        /// Update the Data Fields with the values passed in, do not update the ID.
        /// </summary>
        /// <param name="data">The values to update</param>
        /// <returns>False if null, else true</returns>
        public bool Update(ArchiveModel data)
        {
            if (data == null)
            {
                return false;
            }

            FName = data.FName;
            LName = data.LName;
            SYear = data.SYear;
            Status = data.Status;
            return true;
        }
    }
}
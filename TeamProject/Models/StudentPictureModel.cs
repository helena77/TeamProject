using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeamProject.Models
{
    /// <summary>
    /// Used when receiving what Picture a Student should be assigned
    /// </summary>
    public class StudentPictureModel
    {
        /// <summary>
        /// The Picture ID to assign to the student
        /// </summary>
        [Display(Name = "PictureId", Description = "Picture Id")]
        [Required(ErrorMessage = "Id is required")]
        public string AvatarId { get; set; }

        /// <summary>
        /// The Student ID to receive the Picture
        /// </summary>
        [Display(Name = "StudentId", Description = "Student Id")]
        [Required(ErrorMessage = "Id is required")]
        public string StudentId { get; set; }
    }
}
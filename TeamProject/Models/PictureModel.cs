using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TeamProject.Models
{
    /// <summary>
    /// Pictures for the system
    /// </summary>
    public class PictureModel
    {
        [Display(Name = "Id", Description = "Picture Id")]
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        [Display(Name = "Uri", Description = "Picture to Show")]
        [Required(ErrorMessage = "Picture is required")]
        public string Uri { get; set; }

        /// <summary>
        /// Create the default values
        /// </summary>
        public void Initialize()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// New Picture
        /// </summary>
        public PictureModel()
        {
            Initialize();
        }

        /// <summary>
        /// Make an Picture from values passed in
        /// </summary>
        /// <param name="uri">The Picture path</param>
        public PictureModel(string uri)
        {
            Initialize();

            Uri = uri;
        }

        /// <summary>
        /// Used to Update Picture Before doing a data save
        /// Updates everything except for the ID
        /// </summary>
        /// <param name="data">Data to update</param>
        public void Update(PictureModel data)
        {
            if (data == null)
            {
                return;
            }

            Uri = data.Uri;
        }
    }
}
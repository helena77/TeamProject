using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProject.Models
{
    /// <summary>
    /// View Model for the Picture Views to have the list of Picture
    /// </summary>
    public class PictureViewModel
    {
        /// <summary>
        /// The List of Picture
        /// </summary>
        public List<PictureModel> AvatarList = new List<PictureModel>();
        public int ListLevel;
    }
}
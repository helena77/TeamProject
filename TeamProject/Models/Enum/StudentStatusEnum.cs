using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProject.Models
{
    /// <summary>
    /// Student Status Options
    /// </summary>
    public enum StudentStatusEnum
    {
        // Logged Out
        Out = 1,

        // Logged In
        In = 2,

        // Student on hold
        Hold = 3
    }
}
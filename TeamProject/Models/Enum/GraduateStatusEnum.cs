using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProject.Models
{
    /// <summary>
    /// Grduate status options
    /// </summary>
    public enum GraduateStatusEnum
    {
        // Successfully Grduate
        Graduate = 1,

        // Droped school
        Drop = 2,

        // Incompleted time requirement of graduation
        Incomplete = 3
    }
}
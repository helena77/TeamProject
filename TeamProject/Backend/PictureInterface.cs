using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProject.Models;

namespace TeamProject.Backend
{

    /// <summary>
    /// Datasource Interface for Picture
    /// </summary>
    public interface IPictureInterface
    {
        PictureModel Create(PictureModel data);
        PictureModel Read(string id);
        PictureModel Update(PictureModel data);
        bool Delete(string id);
        List<PictureModel> Index();
        void Reset();
    }
}
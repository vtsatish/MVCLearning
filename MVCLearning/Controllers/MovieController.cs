using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLearning.Models;

namespace MVCLearning.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Analytics
        public ActionResult Analytics()
        {
            var movieObject = new Movie() { MovieName = "Avengers", MovieId = 1 };
            return View(movieObject);


        }
    }
}
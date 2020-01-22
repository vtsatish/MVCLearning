using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLearning.Models;

namespace MVCLearning.Controllers
{
    public class SongController : Controller
    {
        // GET: Song
        public ActionResult Counter()
        {
            Song.songcounter = DateTime.Now.Second;
            return Content("There are " + Song.songcounter + "songs");
        }

        public ActionResult GetSong(int id=0)
        {
            if(id > 0)
            {
                return Content("Song you have requested is : " + id);
            }
            else
            {
                return Content("No id passed");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLearning.Models
{
    public class Song
    {
        public static int songcounter = 0;
        public Song()
        {
            songcounter++;
        }
    }
}
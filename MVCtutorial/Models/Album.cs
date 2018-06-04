using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtutorial.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public String Title { get; set; }

        public Artist Artist { get; set; }

        public virtual List<Review> Review { get; set; }
    }
}
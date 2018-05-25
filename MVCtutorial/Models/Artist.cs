using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtutorial.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public String Name { get; set; }

        public List<Album> Albums { get; set; }
    }

    public class Album
    {
        public int AlbumID { get; set; }

        public String Title { get; set; }

        public Artist Artist { get; set; }
    }
}
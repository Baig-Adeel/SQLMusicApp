using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMusicApp
{
    public class Album
    {
        public int ID { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        //All work has been done with above fields following is additional field to fetch both tables from 
        //database and not call each time we click an album reduces traffic.
        public List<Track> tracks { get; set; }


    }
}

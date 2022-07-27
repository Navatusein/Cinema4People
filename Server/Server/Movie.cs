using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Movie
    {
        public string Title { set; get; }
        public string TrailerLink { set; get; }
        public string Description { set; get; }//could add actors as extra variable/field
        public int Duration { set; get; }
        //public DateTime MovieStart { set; get; }
        public double Rating { set; get; }//
        public List<string> Comments { set; get; }
        public Bitmap Poster { set; get; }
        public List<Actor> Actors { get; set; }
        public string Genres { set; get; }



    }
}

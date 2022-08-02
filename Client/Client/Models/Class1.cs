using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class MoviesDB
    {
        public int Id { get; set; }
        public string Title { set; get; }
        public string TrailerLink { set; get; }
        public string Description { set; get; }//could add actors as extra variable/field
        public int Duration { set; get; }
        public double Rating { set; get; }
        public byte[] Poster { set; get; }
        public string Genres { set; get; }
        public DateTime time { get; set; }
    }
}

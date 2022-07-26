using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class MovieDb
    {
        public MovieDb()
        {
            ActorsToMovies = new HashSet<ActorToMovieDb>();
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string Title { set; get; }
        public string TrailerLink { set; get; }
        public string Description { set; get; }//could add actors as extra variable/field
        public int Duration { set; get; }
        public double Rating { set; get; }
        public byte[] Poster { set; get; }
        public string Genres { set; get; }

        public virtual ICollection<ActorToMovieDb> ActorsToMovies { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

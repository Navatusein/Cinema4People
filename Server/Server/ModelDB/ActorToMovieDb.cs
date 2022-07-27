using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class ActorToMovieDb
    {
        public int Id { get; set; }
        public int ActorsId { get; set; }
        public int MoviesId { get; set; }

        public virtual ActorDb Actor { get; set; }

        public virtual MovieDb Movie { get; set; }
}
}

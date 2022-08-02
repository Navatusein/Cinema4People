using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class ActorDb
    {
        public ActorDb()
        {
            ActorsToMovies = new HashSet<ActorToMovieDb>();
        }

        [Key]
        public int Id { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        public byte[] ActorPhoto { get; set; }

        public virtual ICollection<ActorToMovieDb> ActorsToMovies { get; set; }
        public override string ToString()
        {
            return String.Format("{0} ; {1} ; {2}", Id, ActorFirstName, ActorLastName);
        }

    }
}

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
        public string ActorName { get; set; }
        public string ActorRole { get; set; }
        public byte[] ActorPhoto { get; set; }

        public virtual ICollection<ActorToMovieDb> ActorsToMovies { get; set; }
        public override string ToString()
        {
            return String.Format("{0} ; {1} ; {2}", Id, ActorName, ActorRole);
        }

    }
}

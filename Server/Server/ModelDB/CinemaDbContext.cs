using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
        : base("DBConnection")
        { }

        public virtual DbSet<ActorDb> Actors { get; set; }
        public virtual DbSet<ActorToMovieDb> ActorsToMovies { get; set; }
        public virtual DbSet<CinemaRoomDb> Rooms { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<MovieDb> Movies { get; set; }
        public virtual DbSet<ProductDb> Products { get; set; }
        public virtual DbSet<SessionDb> Sessions { get; set; }


    }
}

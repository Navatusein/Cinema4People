using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
         : base("DBConnection") 
        { }
    }
}

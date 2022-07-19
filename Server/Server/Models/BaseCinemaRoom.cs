using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    internal abstract class BaseCinemaRoom
    {
        protected int roomId;
        protected string name;
        protected Dictionary<(int Row, int Column), Seat> seats;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class RoomTypeDb
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public float Price { get; set; }
        public string Types { get; set; }
        public int CinemaRoomDbId { get; set; }
        public virtual CinemaRoomDb CinemaRoom { get; set; }
    }
}

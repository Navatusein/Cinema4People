using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class CinemaRoomDb
    {
        public CinemaRoomDb()
        {
            RoomSeats = new HashSet<RoomSeatDb>();
            RoomTypes = new HashSet<RoomTypeDb>();
        }
        [Key]
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ; {1} ; {2} ; {3}", Id, RoomNumber, RoomName,Price);
        }
        public virtual ICollection<RoomSeatDb> RoomSeats { get; set; }
        public virtual ICollection<RoomTypeDb> RoomTypes { get; set; }
    }
}

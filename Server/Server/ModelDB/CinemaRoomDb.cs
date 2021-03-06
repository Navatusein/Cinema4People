using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    public class CinemaRoomDb
    {
        [Key]
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return String.Format("{0} ; {1} ; {2} ; {3}", Id, RoomNumber, RoomName,Price);
        }

    }
}

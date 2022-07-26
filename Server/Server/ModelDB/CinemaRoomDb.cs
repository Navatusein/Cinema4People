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
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public double Price { get; set; }
    }
}

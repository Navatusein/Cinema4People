using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class SessionDb
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int MovieId { get; set; }
        public int RoomId { get; set; }
        public UInt32 IncomeTicket { get; set; }
        public UInt32 IncomeBar { get; set; }

        public virtual CinemaRoomDb CinemaRoom { get; set; }
        public virtual MovieDb Movie { get; set; }
    }
}

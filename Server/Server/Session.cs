using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Session
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string MovieTitle { get; set; }
        public int Room { get; set; }
        public UInt32 IncomeTicket { get; set; }
        public UInt32 IncomeBar { get; set; }

    }
}

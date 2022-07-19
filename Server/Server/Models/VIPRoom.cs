using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    internal class VIPRoom : BaseCinemaRoom
    {
        public VIPRoom()
        {
            this.name = "NONAME";
            this.seats = new Dictionary<(int Row, int Column), Seat>();
        }

        public VIPRoom(int[][] size, string name, double price)
        {
            this.name = name;
            this.seats = new Dictionary<(int Row, int Column), Seat>(size.Length);

            Seat seat = new Seat(price);

            for (int i = 0; i < size.Length; i++)
            {
                for (int j = 0; j < size[i].Length; j++)
                {
                    seats.Add((i, j), seat);
                }
            }
        }

        public VIPRoom(int rowAmount, int columnAmount, string name, Seat seat)
        {
            this.name = name;
            this.seats = new Dictionary<(int Row, int Column), Seat>(rowAmount * columnAmount);

            for (int r = 0; r < rowAmount; r++)
            {
                for (int c = 0; c < columnAmount; c++)
                {
                    seats.Add((r, c), seat);
                }
            }
        }

        public VIPRoom(int[][] size, string name, Seat seat)
        {
            this.name = name;
            this.seats = new Dictionary<(int Row, int Column), Seat>(size.Length);

            for (int i = 0; i < size.Length; i++)
            {
                for (int j = 0; j < size[i].Length; j++)
                {
                    seats.Add((i, j), seat);
                }
            }
        }
    }
}

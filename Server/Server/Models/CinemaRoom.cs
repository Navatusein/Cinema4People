using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    /// <summary>
    /// Клас комнаты
    /// </summary>
    public class CinemaRoom
    {
        // зделать ценовую политику
        int roomId;//номер 
        string name;//название 
        double price;//цена
        Dictionary<(int Row, int Column), bool> seats;//схема [(ряд, индекс в ряду), занято/нет]

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CinemaRoom()
        {
            this.name = "NONAME";
            this.seats = new Dictionary<(int Row, int Column), bool>();
            this.price = 0.01;
        }
        /// <summary>
        /// Параметризирований конструктор
        /// </summary>
        /// <param name="size">Размер</param>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        public CinemaRoom(int[][] size, string name, double price)
        {
            this.name = name;
            this.price = price;
            this.seats = new Dictionary<(int Row, int Column), bool>(size.Length);

            for (int i = 0; i < size.Length; i++)
            {
                for (int j = 0; j < size[i].Length; j++)
                {
                    seats.Add((i, j), true);
                }
            }
        }

    }
}

using System;
using System.Collections;
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
        public string name;//название 
        double price;//цена
        public Dictionary<(int Row, int Column), bool> seats;//схема [(ряд, индекс в ряду), занято/нет]
        public Dictionary<(int Row, float Price), string> types; // dictionary for types(seats) of rows
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CinemaRoom()
        {
            this.name = "NONAME";
            this.seats = new Dictionary<(int Row, int Column), bool>();
            this.types = new Dictionary<(int Row, float Price), string>();
            this.price = 0.01;
        }
        /// <summary>
        /// Параметризирований конструктор
        /// </summary>
        /// <param name="size">Размер</param>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        public CinemaRoom(int[,] size, string name, string[] masstypes) //double price)
        {
            this.name = name;
            //this.price = price;
            this.seats = new Dictionary<(int Row, int Column), bool>(size.Length / 2);
            this.types = new Dictionary<(int Row, float Price), string>(size.Length / 2);

            for (int i = 0; i < size.Length / 2; i++)
            {
                for(int j = 0; j < size[i,0]; j++)
                    seats.Add((i, j), true);

                types.Add((i, size[i,1]), masstypes[i]);
            }
        }
    }
}

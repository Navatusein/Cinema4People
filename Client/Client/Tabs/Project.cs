using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFavouriteProject
{
    public partial class Form1 : Form
    {
        static int move = 0;
        static int actor = 10;

        public Form1()
        {
            InitializeComponent();
            Actor actor = new Actor();
        }

        public CinemaRoom(int[,] size, string name, string[]  masstypes)
        {
            this.name = name;

            this.seats = new Dictionary<(int Row, int Column), bool>(size.Length / 2);
            this.types = new Dictionary<(int Row, float Price), string>(size.Length / 2);

            for(int i = 0; i < size.Length; i++)
            {
                
            }
        }
        public class Tickets
        {
            public string TicketNameFilm { get; set; }
            
            public string TicketMoneyCent { get; set; }

            public string TicketSale { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Move%2 == 0)
            button1.BackColor = ConsoleColor.Green;
            else
            button1.BackColor = ConsoleColor.AliceBlue;
            Move++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Move%4 == 0)
            button2.BackColor = ConsoleColor.DarkRed;
            else
            button2.BackColor = ConsoleColor.DarkGreen;
            Move++;

            if(actor%5 == 0)
            {
              Thread thread = new Thread(actor);
              thread.Start();
            }
            
            else
            {
                thread.Join();
                thread.Stop();
            }
        }
        private void Tickets_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(Tickets);
            t1.Start(tickets);
            try 
            {
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    tickets = new Bitmap(ofd1.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            t1.Name("CinemaTickets");
        }

    }
}
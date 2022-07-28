using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.ModelDB;

namespace Server
{
    public partial class Form1 : Form
    {
        CinemaDbContext db = null;
        public Form1()
        {
            InitializeComponent();
          //  afisha = new List<Session>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            //comboBox1.Items.AddRange(комнаты с класса Room)
            db = new CinemaDbContext();
            cbRooms.DataSource = db.Rooms.ToList();
            cbMovies.DataSource = db.Movies.ToList();

        }
        
        private void btAddtoFilm_Click(object sender, EventArgs e)
        {
            //открываеться форма создания класа Movie
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();

            cbMovies.DataSource = db.Movies.ToList();
        }

        private void btAddtoAfisha_Click(object sender, EventArgs e)
        {

            //if (DateTime.Now > dateTimePicker1.Value /*|| String.IsNullOrEmpty(tbTitile.Text)*/ || cbRooms.SelectedIndex == -1)
            //    return;
          
            SessionDb session = new SessionDb
            {
                Date = dateTimePicker1.Value.Date,
                Time = dateTimePicker1.Value.TimeOfDay,
                MovieId = Convert.ToInt32(cbMovies.Text.Substring(0, 1)),
                RoomId = Convert.ToInt32(cbRooms.Text.Substring(0, 1)),
                IncomeBar = 0,
                IncomeTicket = 0
            };
            db.Sessions.Add(session);
            db.SaveChanges();
        }

        /*SQL
             create table Afisha(
                     id int identity(1,1) PRIMARY KEY,
                     titleMovie nvarchar(255) not null,
                     dateMovie date not null,
                     timeMovie time not null,
                     Room int not null,
                     incomeTicket int not null,
                     income_bar int not null,
             )

         ALTER TABLE Afisha
         ADD CONSTRAINT UQ_Afisha unique (titleMovie,dateMovie,timeMovie,Room);
 */
    }
}

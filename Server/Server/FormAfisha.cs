using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormAfisha : Form
    {
        List<Session> afisha = null;
        public FormAfisha()
        {
            InitializeComponent();
            afisha = new List<Session>();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            //comboBox1.Items.AddRange(комнаты с класса Room)
            //cbMovie.Items.AddRange(будем брать доступные фильмы с базы данных )
            cbRooms.Items.Add(1);
            cbRooms.Items.Add(2);
            cbMovie.Items.Add("Monsters");
            cbMovie.Items.Add("Harry Potter");
        }
        
        private void btAddtoFilm_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }

        private void btAddtoAfisha_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > dateTimePicker1.Value || /*String.IsNullOrEmpty(tbTitile.Text) ||*/ cbRooms.SelectedIndex == -1)
                return;
            afisha.Add(new Session
            {
                //Date = dateTimePicker1.Value.Month.ToString() +":"+ dateTimePicker1.Value.Day.ToString() +":"+dateTimePicker1.Value.Year.ToString() ,
                Date = dateTimePicker1.Value.Date,
                Time = dateTimePicker1.Value.TimeOfDay,
                //  MovieTitle = tbTitile.Text, их нужно вытягивать с базы данных по id 
                // Room = Convert.ToInt32(cbRooms.SelectedItem), их нужно вытягивать с базы данных по id 
                IncomeTicket = 0,
                IncomeBar = 0
            });
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

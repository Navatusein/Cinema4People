using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Models;

namespace Client.Tabs
{
    public partial class TabAfisha : Form
    {


        public string movie { get; set; }

        public List<MoviesDB> movies = new List<MoviesDB>();


        private Size cardSize;

        private FormMain formMain;

        public TabAfisha(FormMain formMain)
        {
            movies.Add(new MoviesDB() { Title = "Lol", Description = "That`s LOL " });
            movies.Add(new MoviesDB() { Title = "Lol1", Description = "That`s LOL 1" });
            movies.Add(new MoviesDB() { Title = "Lol2", Description = "That`s LOL 2" });
            movies.Add(new MoviesDB() { Title = "Lol3", Description = "That`s LOL 3" });

            InitializeComponent();
     
            this.formMain = formMain;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;

            cardSize = new Size(160, 200);

            ReDraw(movies);
        }

        private void ReDraw(List<MoviesDB> movies)
        {
            if (movies == null) 
                return;

            int cardsCount = 0;
    
            int cardsInRow = panelContext.Width / (cardSize.Width + 1);

            int locationX = ((panelContext.Width - 16) - (cardsInRow * cardSize.Width)) / 2;
            int locationY = 12;

            panelContext.Controls.Clear();

            while (true)
            {
                for (int j = 0; j < cardsInRow; j++)
                {
                    if (cardsCount >= movies.Count)
                        return;

                    Panel card = CreateCard(new Point(locationX, locationY), cardsCount);

                    FillCard(ref card, movies[cardsCount]);

                    locationX += cardSize.Width;

                    panelContext.Controls.Add(card);

                    cardsCount++;
                }

                locationX = ((panelContext.Width - 16) - (cardsInRow * cardSize.Width)) / 2;
                locationY += cardSize.Height;
            }
        }

        private Panel CreateCard(Point location, int index)
        {
            int margin = 6;
            int labelHeight = 25;

            Panel card = new Panel();

            card.Size = cardSize;
            card.Margin = new Padding(0);
            card.Location = location;

            PictureBox poster = new PictureBox();

            poster.Width = cardSize.Width - margin;
            poster.Height = cardSize.Height - margin - labelHeight;
            poster.Location = new Point(3, 3);
            poster.BackColor = Color.DarkGray;
            poster.Tag = index;
            poster.Click += OpenFilm;

            Label label = new Label();
            label.Name = card.Controls.Count.ToString();
            label.Location = new Point(3, (poster.Location.X + poster.Height));
            label.AutoSize = false;
            label.Width = cardSize.Width - margin;
            label.Height = labelHeight;

            label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.BorderStyle = BorderStyle.FixedSingle;

            card.Controls.Add(poster);
            card.Controls.Add(label);

            return card;
        }

        private void FillCard(ref Panel panel, MoviesDB movie)
        {
            foreach (var element in panel.Controls)
            {
                if (element is PictureBox)
                {
                    //using (var ms = new MemoryStream(movie.Poster))
                    //{
                    //    (element as PictureBox).Image = Image.FromStream(ms);
                    //}
                }

                if (element is Label)
                {
                    (element as Label).Text = movie.Title;
                }
            }
        }

        private void TabAfisha_Resize(object sender, EventArgs e)
        {
            ReDraw(movies);
        }

        protected void OpenFilm(object sender, EventArgs e)
        {
            Label label = sender as Label;
            this.Close();
            var pb = sender as PictureBox;
           
            formMain.showFilm(movies[Convert.ToInt32(pb.Tag)]);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            List<Seans> s = new List<Seans>();
            TabFilter filter = new TabFilter(this.movies, s);

            if (ShowDialog(filter) == DialogResult.OK)
            {
                ReDraw(filter.Filtred);
            }
         }
    }
    public class Seans //Создать или подключить
    {
        int id;
        public List<DateTime> dateTimes;
        string room;
        public MoviesDB movie;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Tabs
{
    public partial class TabAfisha : Form
    {
        int counter = 0;
        List<MyMovie> movies = new List<MyMovie>();

        private Size cardSize;

        private FormMain formMain;

        public TabAfisha(FormMain formMain)
        {
            
            InitializeComponent();


            movies.Add(new MyMovie() { Name = "Lol", Description = "That`s LOL "});
            movies.Add(new MyMovie() { Name = "Lol1", Description = "That`s LOL 1" });
            movies.Add(new MyMovie() { Name = "Lol2", Description = "That`s LOL 2" });
            movies.Add(new MyMovie() { Name = "Lol3", Description = "That`s LOL 3" });

            this.formMain = formMain;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;

            cardSize = new Size(160, 200);

            ReDraw();



        }

        private void ReDraw()
        {
            int cardsCount = 0;
    
            int cardsInRow = panelContext.Width / cardSize.Width;

            int locationX = ((panelContext.Width - 16) - (cardsInRow * cardSize.Width)) / 2;
            int locationY = 12;

            panelContext.Controls.Clear();
            
            while(true)
            {
                for (int j = 0; j < cardsInRow; j++)
                {
                    if (cardsCount >= movies.Count)
                        return;

                    Panel card = CreateCard(new Point(locationX, locationY), movies[cardsCount]);
                    locationX += cardSize.Width;

                    panelContext.Controls.Add(card);

                    cardsCount++;
                }

                locationX = ((panelContext.Width - 16) - (cardsInRow * cardSize.Width)) / 2;
                locationY += cardSize.Height;
            }
        }

        private Panel CreateCard(Point location, MyMovie movie)
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
            poster.Tag = counter;
            counter++;
            poster.Click += OpenFilm;


            Label label = new Label();
            label.Name = card.Controls.Count.ToString();
            label.Location = new Point(3, (poster.Location.X + poster.Height));
            label.AutoSize = false;
            label.Width = cardSize.Width - margin;
            label.Height = labelHeight;
            label.Text = movie.Name;
            label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.BorderStyle = BorderStyle.FixedSingle;


            card.Controls.Add(poster);
            card.Controls.Add(label);

            return card;
        }

        private void TabAfisha_Resize(object sender, EventArgs e)
        {
            ReDraw();
        }

        protected void OpenFilm(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
           
            this.DialogResult = DialogResult.OK;
            formMain.showFilm(movies[Convert.ToInt32(pb.Tag)]);
         }
    }

    public class MyMovie
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

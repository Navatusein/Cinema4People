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
    //class MoviesDB
    //{
    //    public int Id { get; set; }
    //    public string Title { set; get; }
    //    public string TrailerLink { set; get; }
    //    public string Description { set; get; }//could add actors as extra variable/field
    //    public int Duration { set; get; }
    //    public double Rating { set; get; }
    //    public byte[] Poster { set; get; }
    //    public string Genres { set; get; }
    //}
    public partial class TabAfisha : Form
    {
        List<MoviesDB> movies = new List<MoviesDB>();

        public string movie { get; set; }

        private Size cardSize;

        public TabAfisha(FormMain formMain)
        {
            
            InitializeComponent();


            movies.Add(new MoviesDB(){Title =  "Azazel" });

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;

            cardSize = new Size(160, 200);

            ReDraw();
        }

        private void ReDraw()
        {
            int cardsCount = 0;
    
            int cardsInRow = panelContext.Width / (cardSize.Width + 1);

            int locationX = ((panelContext.Width - 16) - (cardsInRow * cardSize.Width)) / 2;
            int locationY = 12;

            panelContext.Controls.Clear();

            
            while(true)
            {
                for (int j = 0; j < cardsInRow; j++)
                {
                    if (cardsCount >= 50) // 50 - Количество карт которые нужно создать.
                        return;

                    Panel card = CreateCard(new Point(locationX, locationY));

                    locationX += cardSize.Width;

                    panelContext.Controls.Add(card);

                    cardsCount++;
                }

                locationX = ((panelContext.Width - 16) - (cardsInRow * cardSize.Width)) / 2;
                locationY += cardSize.Height;
            }
        }

        private Panel CreateCard(Point location)
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


            Label label = new Label();
            label.Name = card.Controls.Count.ToString();
            label.Location = new Point(3, (poster.Location.X + poster.Height));
            label.AutoSize = false;
            label.Width = cardSize.Width - margin;
            label.Height = labelHeight;
            label.Text = "Azraelll";//movies[0];
            label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Click += LB_Click;


            card.Controls.Add(poster);
            card.Controls.Add(label);

            return card;
        }

        private void TabAfisha_Resize(object sender, EventArgs e)
        {
            ReDraw();
        }

        protected void LB_Click(object sender, EventArgs e)
        {
            Label label = (sender as Label);
            this.DialogResult = DialogResult.OK;
            this.Close();
        
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            TabFilter filter = new TabFilter(this.movies);
            ShowDialog(filter);

            
        }
    }
}

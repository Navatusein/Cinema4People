﻿using System;
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
        List<MyMovie> movies = new List<MyMovie>();

        private Size cardSize;

        private FormMain formMain;

        public TabAfisha(FormMain formMain)
        {
            
            InitializeComponent();

            this.formMain = formMain;

            movies.Add(new MyMovie() { Name = "Lol" });

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
            label.Click += OpenFilm;


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
            Label label = (sender as Label);
            this.DialogResult = DialogResult.OK;

            formMain.showFilm();
        }
    }

    class MyMovie
    {
        public string Name { get; set; }
    }
}

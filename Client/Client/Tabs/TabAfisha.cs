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
        private Size cardSize;

        public TabAfisha()
        {
            InitializeComponent();

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
            label.Location = new Point(3, (poster.Location.X + poster.Height));
            label.AutoSize = false;
            label.Width = cardSize.Width - margin;
            label.Height = labelHeight;
            label.Text = "13123123123121231231lkjlkjlkjlkjlkj";
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
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Models;

namespace Client.Tabs
{
    public partial class TabFilm : Form
    {
        
        public TabFilm(MoviesDB movie)
        {
            InitializeComponent();
            labelFilmName.Text = movie.Title;
            labelFilmDescription.Text = movie.Description;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {

        }

        private void panelContext_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabFilm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            string[] rNames = { "1", "2" };
            string[] rTimes = { "1", "2" };
            TabSelectRoom tsr = new TabSelectRoom();
            tsr.cbRoom.Items.AddRange(rNames);
            tsr.cbTime.Items.AddRange(rTimes);
            tsr.ShowDialog();
        }
    }
}

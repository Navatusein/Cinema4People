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
    public partial class TabFilm : Form
    {
        
        public TabFilm(MyMovie movie)
        {
            InitializeComponent();
            labelFilmName.Text = movie.Name;
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
    }
}

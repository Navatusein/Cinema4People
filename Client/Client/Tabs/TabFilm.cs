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
        public TabFilm()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;
        }

        private void panelContext_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

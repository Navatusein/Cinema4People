using Client.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        Button lastButton;

        public FormMain()
        {
            InitializeComponent();


            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void buttonTabAfisha_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            if (lastButton != null)
                lastButton.BackColor = Color.Transparent;

            lastButton = sender as Button;

            lastButton.BackColor = Color.FromArgb(31, 31, 31);

            panelForm.Controls.Clear();
            TabAfisha tab = new TabAfisha();
            panelForm.Controls.Add(tab);
            tab.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;

            if (lastButton != null)
                lastButton.BackColor = Color.Transparent;

            lastButton = sender as Button;

            lastButton.BackColor = Color.FromArgb(31, 31, 31);

            lastButton = sender as Button;
            panelForm.Controls.Clear();
            TabFilm tab = new TabFilm();
            panelForm.Controls.Add(tab);
            tab.Show();
        }
    }
}

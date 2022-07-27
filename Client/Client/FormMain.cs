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
        string movie;
        public FormMain()
        {
            InitializeComponent();
            
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            panelForm.Controls.Clear();

            //TabAfisha tab = new TabAfisha();
            TabFilm tab = new TabFilm();

            panelForm.Controls.Add(tab);

            tab.Show();
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            /*
            lastButton = sender as Button;
            panelForm.Controls.Clear();
            TabFilm tab = new TabFilm(); --- hook click on movie
            panelForm.Controls.Add(tab);
            tab.Show();
            */
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;

            lastButton = sender as Button;

            panelForm.Controls.Clear();

            TabAfisha tab = new TabAfisha();

            panelForm.Controls.Add(tab);

            tab.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if (panelForm.Controls[0] is TabAfisha) return;
            if (panelForm.Controls[0] is TabFilm)
            {
                btMain_Click(sender, e);
            }
            else
            {
                if (panelForm.Controls[0] is TabCheckout)
                {
                    lastButton = sender as Button;

                    panelForm.Controls.Clear();
                    TabFilm tab = new TabFilm(movie);
                    panelForm.Controls.Add(tab);
                    tab.Show();
                }
            }
        }
        
        public void showFilm()
        {
            TabAfisha temp = panelForm.Controls[0] as TabAfisha;
           if (temp.DialogResult == DialogResult.OK)
            {
                movie = temp.movie;
                panelForm.Controls.Clear();
                TabFilm tab = new TabFilm(movie);
                panelForm.Controls.Add(tab);
                tab.Show();
            }
        }
    }
}

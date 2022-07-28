using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormMain : Form
    {
        Form2 room = null;
        Bar bar = null;
        Form1 afisha = null;
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void btRoom_Click(object sender, EventArgs e)
        {

            room = new Form2();
            room.FormClosed += Room_FormClosed;
            room.Show();
            btRoom.Enabled = false;
            
        }

        private void Room_FormClosed(object sender, FormClosedEventArgs e)
        {
            btRoom.Enabled = true;
            
        }

        private void btBar_Click(object sender, EventArgs e)
        {
            bar = new Bar();
            bar.FormClosed += Bar_FormClosed;
            bar.Show();
            btBar.Enabled = false;
        }

        private void Bar_FormClosed(object sender, FormClosedEventArgs e)
        {
            btBar.Enabled = true;
        }

        private void btAfisha_Click(object sender, EventArgs e)
        {
             afisha = new Form1();
            afisha.FormClosed += Afisha_FormClosed;
            afisha.Show();
            btAfisha.Enabled = false;
        }

        private void Afisha_FormClosed(object sender, FormClosedEventArgs e)
        {
            btAfisha.Enabled = true;
        }

   
    }
}

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
    public partial class TabSelectRoom : Form
    {
        public TabSelectRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<(int, int)> size = new List<(int, int)>();//row, number of places in this row
            size.Add((0, 5));
            size.Add((1, 4));
            size.Add((2, 6));
            size.Add((3, 14));
            TabRoom tr = new TabRoom();
            for (int i = 0; i < size.Count; i++)
            {
                Label l = new Label();
                l.Text = (i + 1).ToString();
                l.Location = new Point(10, 43 + i * 40);
                for (int j = 0; j < size[i].Item2; j++)
                {
                    Button b = new Button();
                    b.Width = 30;
                    b.Height = 30;
                    b.Text = (j + 1).ToString();
                    b.FlatStyle = FlatStyle.Flat;
                    b.Location = new Point(30 + j * 35, 30 + i * 40);
                    b.Click += B_Click;
                    tr.panel1.Controls.Add(b);
                }
                tr.panel1.Controls.Add(l);
            }
            tr.ShowDialog();
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if (b.BackColor == Color.PaleGreen)
                b.BackColor = Color.WhiteSmoke;
            else if (b.BackColor != Color.PaleVioletRed)
                b.BackColor = Color.PaleGreen;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Models;

namespace Server
{
    public partial class Bar : Form
    {
        List<Product> products;
        private OpenFileDialog openFileDialog;

        public Bar()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametb.Text) || string.IsNullOrWhiteSpace(pricetb.Text) || string.IsNullOrWhiteSpace(quantitytb.Text) || string.IsNullOrWhiteSpace(imagetb.Text))
            {
                MessageBox.Show("Enter all fields");
                return;
            }
            Product tmp = new Product(nametb.Text, (float)Convert.ToDouble(pricetb.Text), Convert.ToInt32(quantitytb.Text), imagetb.Text);
            products.Add(tmp);
        }

        private void imagebtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fn = openFileDialog.FileName;
                    //var sr = new StreamReader(openFileDialog.FileName);
                    //SetText(sr.ReadToEnd());
                    imagetb.Text = fn;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}

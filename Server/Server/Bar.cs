using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.ModelDB;
using Server.Models;

namespace Server
{
    public partial class Bar : Form
    {
        List<Product> products = new List<Product>();
        CinemaDbContext db = null;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public Bar()
        {
            InitializeComponent();
          

            // Set the view to show details.
            productslv.View = View.Details;
            // Allow the user to edit item text.
            productslv.LabelEdit = true;
            // Allow the user to rearrange columns.
            productslv.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            productslv.FullRowSelect = true;
            // Display grid lines.
            productslv.GridLines = true;
            // Sort the items in the list in ascending order.
            productslv.Sorting = System.Windows.Forms.SortOrder.Ascending;
            db = new CinemaDbContext();

           // products = LoadProduct();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nametb.Text) || string.IsNullOrWhiteSpace(pricetb.Text) || string.IsNullOrWhiteSpace(quantitytb.Text) || string.IsNullOrWhiteSpace(imagetb.Text))
                {
                    MessageBox.Show("Enter all fields");
                    return;
                }

                Product tmp = new Product(nametb.Text, (float)Convert.ToDouble(pricetb.Text), Convert.ToInt32(quantitytb.Text), imagetb.Text);
                ProductDb productDb = new ProductDb
                {
                    Name = nametb.Text,
                    Price = (float)Convert.ToDouble(pricetb.Text),
                    Quantity = Convert.ToInt32(quantitytb.Text),
                    PathImage = imagetb.Text
                };
                db.Products.Add(productDb);
                db.SaveChanges();
                //products.Add(tmp);
                UpdateProductList();
            }
            catch (FormatException)
            {
                MessageBox.Show("Cheked value of price of quantity");
            }
            
        }

        private void UpdateProductList() {
            productslv.Clear();
            for (int i = 0; i < products.Count; i++)
            {

                ListViewItem tmp = new ListViewItem(products[i].Name.ToString());
                tmp.SubItems.Add(products[i].Price.ToString());
                tmp.SubItems.Add(products[i].Quantity.ToString());
                productslv.Items.Add(tmp);
            }

            productslv.Columns.Add("Name", 100, HorizontalAlignment.Left);
            productslv.Columns.Add("Price", 50, HorizontalAlignment.Left);
            productslv.Columns.Add("Quantity", 50, HorizontalAlignment.Center);

            ImageList imageListSmall = new ImageList();

            for (int i = 0; i < products.Count; i++)
                imageListSmall.Images.Add(Bitmap.FromFile(products[i].Image));
            
            productslv.SmallImageList = imageListSmall;
        }

        private void imagebtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fn = openFileDialog.FileName;
                    imagetb.Text = fn;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametb.Text))
            {
                MessageBox.Show("Enter name of product that you want to remove");
                return;
            }
            else
            {
                Product tmp = null;
                foreach (var item in products)
                {
                    if (item.Name == nametb.Text)
                    {
                        tmp = item;
                        products.Remove(tmp);
                    }
                }
                if (tmp == null)
                {
                    MessageBox.Show("Input correct name of product");
                }
            }
            
        }
        private List<Product> LoadProduct() {
            string connectionString = "Server=178.151.124.250,21062; Database=Cinema4People; User Id=Cinema4PeopleUser; Password=sqQEPTC8e9wr; Trusted_Connection=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = string.Empty;//need command for load from DB
                command.Connection = connection;
            }

            return null;
        }

        private void SaveProduct()
        {
            string connectionString = string.Empty;//@"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            string sqlExpression = string.Empty;//command for insert

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
            }
            Console.Read();
        }
    }
}

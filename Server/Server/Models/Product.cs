using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Product
    {
        string _name;
        float _price;
        int _quantity;
        string _image;

        public Product(string name, float price, int quantity, string image)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
            _image = image;
        }

        public Product()
        {
            _name = string.Empty;
            _price = 0;
            _quantity = 0;
            _image = string.Empty;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }
        public float Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value < 0)
                {
                    _price = value;
                }
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                if (value < 0)
                {
                    _quantity = value;
                }
            }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _image = value;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Client.Models;

namespace Client
{
    public class Bar
    {
        List<Product> _products;
        double sumOfDay;

        public List<Product> Products { get => _products; private set => _products = value; }

        public Bar()
        {
            _products = new List<Product>();
            sumOfDay = 0;
        }

        public Bar(List<Product> pr, double sod)
        {
            _products = pr;
            sumOfDay = sod;
        }

        public bool isEnoughQuantity(Product p, int quantityOfProduct)
        {
            return quantityOfProduct <= _products[_products.IndexOf(p)].Quantity;
        }


        public double Buy(Product p, int quantityOfProduct)
        {
            _products[_products.IndexOf(p)].Quantity -= quantityOfProduct;
            double tmp = _products[_products.IndexOf(p)].Price * quantityOfProduct;
            sumOfDay += tmp;
            return tmp;
        }

    }


}


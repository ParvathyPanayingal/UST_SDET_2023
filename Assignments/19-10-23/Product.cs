using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
     class Product
    {
        public string? productName;
        public double price;
        public int quantity;


        

        public Product(string productName, double price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;

        }

        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }

        public double ProductValue()
        {
            return price * quantity;
        }


    }
}




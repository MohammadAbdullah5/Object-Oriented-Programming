using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product
    {
        public string name;
        public string category;
        public int price;
        public int quantity;
        public int threshold;
        public float tax;

        public Product(string name, string category, int price, int quantity, int threshold)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.threshold = threshold;
        }

        public void getTax()
        {
            if (this.category == "Grocery")
            {
                this.tax = price - (0.1F * this.price);
            }

            else if (this.category == "Fruit")
            {
                this.tax = price - (0.05F * this.price);
            }

            else
            {
                this.tax = price - (0.15F * this.price);
            }
        }
    }
}

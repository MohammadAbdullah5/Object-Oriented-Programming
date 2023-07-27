using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Product
    {
        public Product()
        {
            name = "Product A";
            category = "Category B";
            price = 0;
            quantity = 0;
            minQuantity = 5;
        }

        public Product(string n)
        {
            name = n;
            category = "Category A";
            price = 0;
            quantity = 0;
            minQuantity = 5;
        }

        public Product(string n, string c)
        {
            name = n;
            category = c;
            price = 0;
            quantity = 0;
            minQuantity = 5;
        }

        public Product(string n, string c, int p)
        {
            name = n;
            category = c;
            price = p;
            quantity = 0;
            minQuantity = 5;
        }

        public Product(string n, string c, int p, int qty)
        {
            name = n;
            category = c;
            price = p;
            quantity = qty;
            minQuantity = 5;
        }

        public Product(string n, string c, int p, int qty, int minQty)
        {
            name = n;
            category = c;
            price = p;
            quantity = qty;
            minQuantity = minQty;
        }

        public Product(Product p)
        {
            name = p.name;
            category = p.category;
            price = p.price;
            quantity = p.quantity;
            minQuantity = p.minQuantity;
        }

        public float tax()
        {
            float salesTax;

            if(category == "Grocery")
            {
                salesTax = 0.1F * price;
            }

            else if(category == "Fruit")
            {
                salesTax = 0.05F * price;
            }

            else
            {
                salesTax = 0.15F * price;
            }
            
            return salesTax;
        }



        public string name;
        public string category;
        public int price;
        public int quantity;
        public int minQuantity;
    }
}

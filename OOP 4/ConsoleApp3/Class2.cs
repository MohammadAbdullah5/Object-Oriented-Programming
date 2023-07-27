using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Customer
    {
        public string customerName;
        public string customerAddress;
        public string customerContact;
        public List<Product> purchasedProducts = new List<Product>();

        public List<Product> getAllPurchasedProducts()
        {
            return purchasedProducts;
        }

        public Customer(string name, string address, string contact)
        {
            this.customerName = name;
            this.customerContact = contact;
            this.customerAddress = address;
        }

        public void addProduct(Product p)
        {
            purchasedProducts.Add(p);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Customer
    {
        public string name; 
        public static List<Product> purchasedProducts = new List<Product>();

        public void addProduct(Product p)
        {
            purchasedProducts.Add(p);
        }
        public List<Product> GetProducts()
        {
            return purchasedProducts;
        }
    }
}

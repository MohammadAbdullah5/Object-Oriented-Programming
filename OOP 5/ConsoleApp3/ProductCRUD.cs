using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ProductCRUD
    {
        public static List<Product> products = new List<Product>();

        public static void Tax()
        {
            foreach (Product product in products)
            {
                product.getTax();
            }
        }

        public static int totalStoreWorth()
        {
            int sum = 0;
            for (int i = 0; i < products.Count; i++)
            {
                sum += products[i].price;
            }
            return sum;
        }

        

        public static List<Product> ProductsToOrder()
        {

            List<Product> newList = new List<Product>();
            foreach (Product p in products)
            {
                if (p.quantity < p.threshold)
                {
                    newList.Add(p);
                }
            }
            return newList;
        }

        public static Product highestPrice()
        {
            int largestPrice = -1000;
            int idx = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].price > largestPrice)
                {
                    largestPrice = products[i].price;
                    idx = i;
                }
            }

            return products[idx];
        }

        public static void addProduct()
        {
            Product product =  ProductUI.addProduct();
            products.Add(product);
        }

        public static void buyProduct(string p)
        {
            foreach(Product product in products)
            {
                if(p == product.name)
                {
                    product.quantity--;
                }
            }
        }

        public static Product isProduct(string p)
        {
            foreach (Product product in products)
            {
                if (p == product.name)
                {
                    return product;
                }
            }
            return null;
        }
    }
}

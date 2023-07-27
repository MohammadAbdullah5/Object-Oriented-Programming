using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ProductUI
    {
        public static Product addProduct()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Category: ");
            string category = Console.ReadLine();
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Threshold: ");
            int minQuantity = int.Parse(Console.ReadLine());
            Product product = new Product(name, category, price, quantity, minQuantity);
            return product;
        }

        public static void showProducts()
        {
            Console.WriteLine("Name       Category       Price       Quantity       Minimum Quantity");
            foreach (var p in ProductCRUD.products)
            {
                Console.WriteLine(p.name + "   " + p.category + "   " + p.price + "       " + p.quantity + "       " + p.threshold);
            }
        }



        public static void showHighestPriceProduct()
        {
            Product product = ProductCRUD.highestPrice();
            Console.WriteLine("Name: " + product.name);
            Console.WriteLine("Category: " + product.category);
            Console.WriteLine("Price: " + product.price);
            Console.WriteLine("Quantity: " + product.quantity);
            Console.WriteLine("Threshold: " + product.threshold);
        }

        public static void showTaxOfAllProducts()
        {
            ProductCRUD.Tax();
            foreach (Product p in ProductCRUD.products)
            {
                Console.WriteLine("Name: " + p.name + "      " + "Sales Tax: " + p.tax);
            }
        }

        public static void showProductsToOrder()
        {
            Console.WriteLine("Products to be Ordered");
            List<Product> requiredProducts = ProductCRUD.ProductsToOrder();
            int i = requiredProducts.Count + 1;
            foreach (Product p in requiredProducts)
            {
                Console.WriteLine(i + ".  " + "Name: " + p.name);
                i++;
            }
        }

        public static void showTotalStoreWorth()
        {
            Console.WriteLine("Store Worth: " + ProductCRUD.totalStoreWorth());
        }
    }
}

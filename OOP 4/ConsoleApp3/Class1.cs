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

        public Product(string name, string category, int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public float calculateTax()
        {
            if(price >= 2000)
            {
                return (float)price * 0.15F;
            }

            else if (price >= 1000 && price < 2000)
            {
                return (float)price * 0.1F;
            }

            else if (price >= 0 && price < 1000)
            {
                return (float)price * 0.05F;
            }

            return (float)price * 0.25F;
        }
    }
}

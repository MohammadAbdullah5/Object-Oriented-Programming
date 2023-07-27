using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.DL;

namespace ConsoleApp2.BL
{
    class CoffeeShop
    {
        public string name;
        public List<string> orders = new List<string>();

        public CoffeeShop(string name)
        {
            this.name = name;
        }       

        public string fulfillOrder()
        {
            if(orders.Count > 0)
            {
                string orderFulfilled = orders[0];
                orders.RemoveAt(0);
                return orderFulfilled;
            }

            else
            {
                return null;
            }
        }

        public List<string> returningListOfOrders()
        {
            if (orders.Count > 0)
            {
                return orders;
            }
            else
            {
                return null;
            }
        }
    }
}

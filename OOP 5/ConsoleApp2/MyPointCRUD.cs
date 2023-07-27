using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyPointCRUD
    {
        public static MyPoint point;
        public static double distanceWithCords(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow((point.getX() - x), 2) + Math.Pow((point.getY() - y), 2));
            return distance;
        }

        public static double distanceWithObject(MyPoint another)
        {
            double distance = Math.Sqrt(Math.Pow((point.getX() - another.x), 2) + Math.Pow((point.getY() - another.y), 2));
            return distance;
        }

        public static double distanceWithZero(MyPoint point1)
        {
            double distance = Math.Sqrt(Math.Pow((point1.getX()), 2) + Math.Pow((point1.getY()), 2));
            return distance;
        }
    }
}

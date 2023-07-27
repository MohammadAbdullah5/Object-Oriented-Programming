using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyLineCRUD
    {
        public static MyLine newLine;
        public static double getLength()
        {
            double distance = Math.Sqrt(Math.Pow((newLine.end.getX() - newLine.begin.getX()), 2) + Math.Pow((newLine.end.getY() - newLine.begin.getY()), 2));
            return distance;
        }

        public static double getGradient()
        {
            double distance = (newLine.end.getY() - newLine.begin.getY()) / (newLine.end.getX() - newLine.begin.getY());
            return distance;
        }

        public static void addObject(MyLine line)
        {
            newLine = line;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PointUI
    {
        public static MyPoint updateBeginInput()
        {
            Console.WriteLine("Enter the coordinate for Begin Line:");
            Console.Write("Enter X Co-Ordinate of begin point: ");
            int beginX = int.Parse(Console.ReadLine());
            Console.Write("Enter Y Co-Ordinate of begin point: ");
            int beginY = int.Parse(Console.ReadLine());

            MyPoint point = new MyPoint(beginX, beginY);
            return point;
        }

        public static MyPoint updateEndInput()
        {
            Console.WriteLine("Enter the coordinate for End Line:");
            Console.Write("Enter X Co-Ordinate of End point: ");
            int endX = int.Parse(Console.ReadLine());
            Console.Write("Enter Y Co-Ordinate of End point: ");
            int endY = int.Parse(Console.ReadLine());

            MyPoint point = new MyPoint(endX, endY);
            return point;
        }

        public static void distOfbeginFromZero()
        {
            Console.WriteLine(MyPointCRUD.distanceWithZero(MyLineCRUD.newLine.begin));
        }

        public static void distOfendFromZero()
        {
            Console.WriteLine(MyPointCRUD.distanceWithZero(MyLineCRUD.newLine.end));
        }
    }
}

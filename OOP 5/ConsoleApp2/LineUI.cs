using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LineUI
    {
        public static MyLine getInputForLine()
        {
            Console.WriteLine("Enter the coordinate for Begin Line:");
            Console.Write("Enter X Co-Ordinate of begin point: ");
            int beginX = int.Parse(Console.ReadLine());
            Console.Write("Enter Y Co-Ordinate of begin point: ");
            int beginY = int.Parse(Console.ReadLine());

            MyPoint begin = new MyPoint(beginX, beginY);

            Console.WriteLine("Enter the coordinate for End Line:");
            Console.Write("Enter X Co-Ordinate of end point: ");
            int endX = int.Parse(Console.ReadLine());
            Console.Write("Enter Y Co-Ordinate of end point: ");
            int endY = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint(endX, endY);

            MyLine line = new MyLine(begin, end);
            return line;
        }

        public static void showBeginPoint()
        {
            Console.Write("Begin X-Coordinate: ");
            Console.WriteLine(MyLineCRUD.newLine.begin.x);
            Console.Write("Begin Y-Coordinate: ");
            Console.WriteLine(MyLineCRUD.newLine.begin.y);
        }

        public static void showEndPoint()
        {
            Console.Write("End X-Coordinate: ");
            Console.WriteLine(MyLineCRUD.newLine.end.x);
            Console.Write("End Y-Coordinate: ");
            Console.WriteLine(MyLineCRUD.newLine.end.y);
        }

        public static void printLength()
        {
            Console.WriteLine("Length of Line: ");
            Console.WriteLine(MyLineCRUD.getLength());
        }

        public static void printGradient()
        {
            Console.WriteLine("Gradient of Line: ");
            Console.WriteLine(MyLineCRUD.getGradient());
        }

    }
}

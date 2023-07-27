using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            do
            {
                option = menu();
                if (option == "1")
                {
                    MyLine myLine = LineUI.getInputForLine();
                    MyLineCRUD.newLine = myLine;
                }

                else if(option == "2")
                {
                    MyPoint point = PointUI.updateBeginInput();
                    MyLineCRUD.newLine.begin = point;
                }

                else if (option == "3")
                {
                    MyPoint point = PointUI.updateEndInput();
                    MyLineCRUD.newLine.end = point;
                }

                else if (option == "4")
                {
                    LineUI.showBeginPoint();
                }

                else if (option == "5")
                {
                    LineUI.showEndPoint();
                }

                else if (option == "6")
                {
                    LineUI.printLength();
                }

                else if (option == "7")
                {
                    LineUI.printGradient();
                }

                else if (option == "8")
                {
                    PointUI.distOfbeginFromZero();
                }

                else if (option == "9")
                {
                    PointUI.distOfendFromZero();
                }

                Console.Clear();
            }
            while (option != "10");
        }

        static string menu()
        {
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update the begin Point");
            Console.WriteLine("3. Update the end Point");
            Console.WriteLine("4. Show the begin Point");
            Console.WriteLine("5. Show the end Point");
            Console.WriteLine("6. Get the Length of the Line");
            Console.WriteLine("7. Get the Gradient of the Line");
            Console.WriteLine("8. Find the distance of begin Point from zero Coordinate");
            Console.WriteLine("9. Find the distance of end Point from zero Coordinate");
            Console.WriteLine("10. EXIT");
            string option = Console.ReadLine();
            return option;
        }
    }
}

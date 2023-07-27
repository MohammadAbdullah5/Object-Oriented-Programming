using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            List<Ship> ships = new List<Ship>();
            do
            {
                option = menu();
                if (option == "1")
                {
                    Console.Write("Enter Ship number: ");
                    string number = Console.ReadLine();

                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.Write("Enter degree: ");
                    int degrees = int.Parse(Console.ReadLine());
                    Console.Write("Enter minutes: ");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.Write("Enter direction: ");
                    char direction = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ship Longitude: ");
                    Angle latitude = new Angle(degrees, minutes, direction);

                    Console.Write("Enter degree: ");
                    int degrees1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter minutes: ");
                    float minutes1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter direction: ");
                    char direction1 = char.Parse(Console.ReadLine());
                    Angle longitude = new Angle(degrees1, minutes1, direction1);
                    Ship ship = new Ship(number, latitude, longitude);
                    ships.Add(ship);
                }

                else if (option == "2")
                {
                    Console.Write("Enter Ship Serial Number to find its position: ");
                    string serial = Console.ReadLine();

                    foreach (Ship ship in ships)
                    {
                        if (ship.number == serial)
                        {
                            ship.showDirection();
                            break;
                        }
                    }
                }

                else if (option == "3")
                {
                    Console.Write("Enter Ship Latitude: ");
                    Console.Write("Enter Latitude Degree: ");
                    int degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude Minutes: ");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude Direction: ");
                    char direction = char.Parse(Console.ReadLine());


                    Console.Write("Enter Ship Longitude: ");
                    Console.Write("Enter Longitude Degree: ");
                    int degree1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude Minutes: ");
                    float minutes1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude Direction: ");
                    char direction1 = char.Parse(Console.ReadLine());

                    foreach (var ship in ships)
                    {
                        if ((degree == ship.Latitude.degrees) && (minutes == ship.Latitude.minutes) && (direction == ship.Latitude.direction))
                        {
                            if ((degree1 == ship.Longitude.degrees) && (minutes1 == ship.Longitude.minutes) && (direction1 == ship.Longitude.direction))
                            {
                                Console.WriteLine("Ship Name: " + ship.number);
                            }
                        }
                    }
                }

                else if (option == "4")
                {
                    Console.Write("Enter Ship Serial Number whose position you want to change: ");
                    string name = Console.ReadLine();
                    foreach (Ship ship in ships)
                    {
                        if (ship.number == name)
                        {

                            Console.Write("Enter Ship Latitude: ");
                            Console.Write("Enter Latitude Degree: ");
                            int degree = int.Parse(Console.ReadLine());
                            Console.Write("Enter Latitude Minutes: ");
                            float minutes = float.Parse(Console.ReadLine());
                            Console.Write("Enter Latitude Direction: ");
                            char direction = char.Parse(Console.ReadLine());
                            ship.Latitude.changeAngle(degree, minutes, direction);

                            Console.Write("Enter Ship Longitude: ");
                            Console.Write("Enter Longitude Degree: ");
                            int degree1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter Longitude Minutes: ");
                            float minutes1 = float.Parse(Console.ReadLine());
                            Console.Write("Enter Longitude Direction: ");
                            char direction1 = char.Parse(Console.ReadLine());
                            ship.Longitude.changeAngle(degree1, minutes1, direction1);
                        }
                    }
                }
                Console.ReadKey();
            }
            while (option != "5");
        }

        static string menu()
        {
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            string option = Console.ReadLine();
            return option;
        }
    }
}

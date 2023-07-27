using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DegreeUI
    {
        public static Degree TakeInputOfDegree()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Duration: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats: ");
            int seats = int.Parse(Console.ReadLine());

            Degree degree = new Degree(name, code, seats);
            return degree;
        }
    }
}

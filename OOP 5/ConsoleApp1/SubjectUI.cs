using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SubjectUI
    {
        public static Subject TakeInputOfSubject()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Fees: ");
            int fees = int.Parse(Console.ReadLine());

            Subject subject = new Subject(name, code, creditHours, fees);
            return subject;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DegreeCRUD
    {
        public static List<Degree> degrees = new List<Degree>();

        public static Degree preferenceDegree(string name)
        {
            foreach (Degree degree in degrees)
            {
                if (name == degree.title)
                {
                    return degree;
                }
            }
            return null;
        }

        public static void addIntoDegreeList(Degree degree)
        {
            degrees.Add(degree);
        }

        public static void viewDegrees()
        {
            foreach (Degree degree in degrees)
            {
                Console.WriteLine(degree.title);
            }
        }
    }
}

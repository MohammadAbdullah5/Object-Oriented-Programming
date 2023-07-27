using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Ship
    {
        public string number;
        public Angle Latitude;
        public Angle Longitude;

        public Ship(string number, Angle Latitude, Angle Longitude)
        {
            this.number = number;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        public void showDirection()
        {
            Console.Write("Latitude: ");
            Console.WriteLine("{0}\u00b0{1}' {2}", Latitude.degrees, Latitude.minutes, Latitude.direction);
            Console.Write("Longitude: ");
            Console.WriteLine("{0}\u00b0{1}' {2}", Longitude.degrees, Longitude.minutes, Longitude.direction);
        }

        public string returnSerial()
        {
            return number;
        }
    }
}

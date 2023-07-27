using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            FireTrucks truck = new FireTrucks();
            HosePipes pipe = new HosePipes(true, true, 5, 2.3);
            FireFighter fighter = new FireFighter("Ahmad");
            FireChief chief = new FireChief("Bilal");
            truck.setPipe(pipe);
            truck.setFighter(fighter);
            truck.setChief(chief);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] {{ '@', ' ', ' '}, { '@', '@', ' '}, { '@', '@', '@'}, { '@', '@', ' '}, { '@', ' ', ' ' }};
            char[,] opTriangle = new char[5, 3] {{ ' ', ' ', '@'}, { ' ', '@', '@'}, { '@', '@', '@'}, { ' ', '@', '@'}, { ' ', ' ', '@'}};
            char[,] point = new char[1, 1] { { 'p' } };
            Boundary b = new Boundary(new Point(0, 0), new Point(90, 0), new Point(0, 90), new Point(90, 90));
            Boundary b1 = new Boundary(new Point(0, 0), new Point(25, 0), new Point(0, 25), new Point(25, 25));
            GameObject g1 = new GameObject(new Point(5, 5), b, triangle, "LeftToRight");    
            GameObject g2 = new GameObject(new Point(15, 15), b, opTriangle, "RightToLeft");
            GameObject g3 = new GameObject(new Point(1, 1), b1, opTriangle, "Diagonal");
            GameObject g4 = new GameObject(new Point(6, 21), b, opTriangle, "Patrol");
            GameObject g5 = new GameObject(new Point(11, 24), b, point, "Projectile");
            List<GameObject> lst = new List<GameObject>();
            lst.Add(g1);
            lst.Add(g2);
            lst.Add(g3);
            lst.Add(g4);
            lst.Add(g5);

            while (true)
            {
                Thread.Sleep(100);
                foreach(GameObject gameObject in lst)
                {
                    gameObject.erase();
                    gameObject.move();
                    gameObject.draw();
                }
            }
        }
    }
}

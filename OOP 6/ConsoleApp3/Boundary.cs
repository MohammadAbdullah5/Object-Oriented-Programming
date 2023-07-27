using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Boundary
    {
        public Point TopLeft;
        public Point TopRight;
        public Point BottomLeft;
        public Point BottomRight;

        public Boundary()
        {
            TopLeft.x = 0;
            TopLeft.y = 0;
            TopRight.x = 90;
            TopRight.y = 0;
            BottomLeft.x = 0;
            BottomLeft.y = 90;
            BottomRight.x = 90;
            BottomRight.y = 90;
        }

        public Boundary(Point TopLeft, Point TopRight, Point BottomLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomRight = BottomRight;
            this.BottomLeft = BottomLeft;
        }
    }
}

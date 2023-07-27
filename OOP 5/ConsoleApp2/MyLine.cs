using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        public MyPoint getBegin()
        {
            return begin;
        }

        public MyPoint getEnd()
        {
            return end;
        }

        public void setBegin(MyPoint point)
        {
            begin = point;
        }

        public void setEnd(MyPoint point)
        {
            end = point;

        }
    }
}
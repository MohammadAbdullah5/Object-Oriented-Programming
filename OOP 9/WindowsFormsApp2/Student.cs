using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Student
    {
        private int id;
        private string name;
        private string regNo;
        

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string RegNo { get => regNo; set => regNo = value; }
    }
}

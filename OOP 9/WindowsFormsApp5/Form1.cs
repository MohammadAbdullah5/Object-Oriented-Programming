using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Colors> colors = new List<Colors>();
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Blue b = new Blue();
            colors.Add(b);
            Green g = new Green();
            colors.Add(g);
            Red r = new Red();
            colors.Add(r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count >= 3)
            {
                count = 0;
            }


            textBox1.BackColor = colors[count].getColor();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
            {
                count = 2;
            }

            textBox1.BackColor = colors[count].getColor();


        }
    }
}

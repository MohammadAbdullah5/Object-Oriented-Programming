using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtBoxName1.Text == txtBoxName2.Text)
            {
                sameOrDiff.Text = "Same";
            }

            else
            {
                sameOrDiff.Text = "Different";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                txtCheckBox.Text = "Both";
            }

            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                txtCheckBox.Text = "CheckBox 1";
            }

            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                txtCheckBox.Text = "CheckBox 2";
            }

            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                txtCheckBox.Text = "None";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            List<string> lists = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lists.Add("Afghanistan");
            lists.Add("Pakistan");
            lists.Add("India");
            lists.Add("Bangladesh");
            comboBox1.Items.Insert(0, "Afghanistan");
            comboBox1.Items.Insert(1, "Bangladesh");
            comboBox1.Items.Insert(2, "India");
            comboBox1.Items.Insert(3, "Pakistan");
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = lists;
            textBox1.Text = comboBox1.Text;
        }

        private void BindComboBox()
        {
        }
    }
}

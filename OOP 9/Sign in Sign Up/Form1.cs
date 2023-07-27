using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sign_in_Sign_Up.DL;
using Sign_in_Sign_Up.BL;

namespace Sign_in_Sign_Up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "Data.txt";
            if(CredentialsDL.readDataFromFile(path))
            {
                MessageBox.Show("File Loaded");
            }

            else
            {
                MessageBox.Show("File Not Loaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

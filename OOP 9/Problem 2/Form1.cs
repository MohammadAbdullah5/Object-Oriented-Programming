using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<MUser> users = new List<MUser>();
        private void Form1_Load(object sender, EventArgs e)
        {
            users.Add(new MUser("abd", "123", "admin"));
            users.Add(new MUser("ali", "456", "client"));
            users.Add(new MUser("ahmed", "789", "client"));
            dataGridView1.DataSource = users;
        }

        private void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MUser user = (MUser)dataGridView1.CurrentRow.DataBoundItem;
            users.Remove(user);
            dataBind();
            MessageBox.Show(user.Username + " has been deleted successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(var user in users)
            {
                if(user.Username == textBox1.Text)
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Username is present in the list");
            }
            else
            {
                MessageBox.Show("Username is not present in the list");
            }
        }
    }
}

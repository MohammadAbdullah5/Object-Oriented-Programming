using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> ss = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
            ss.Add(new Student() { Id = 1, Name = "Ali", RegNo = "21" });
            ss.Add(new Student() { Id = 2, Name = "Bilal", RegNo = "22" });
            ss.Add(new Student() { Id = 3, Name = "Cheema", RegNo = "23" });
            dataGridView1.DataSource = ss;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student = (Student)dataGridView1.CurrentRow.DataBoundItem;
            ss.Remove(student);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ss;
            dataGridView1.Refresh();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_In_Sign_Up_2
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(txtUsername.Text, txtPassword.Text, txtRole.Text);
            MUserDL.addIntoList(user);
            this.Close();
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}

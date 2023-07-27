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
    public partial class EditUserForm : Form
    {
        private MUser previous;

        public EditUserForm(MUser previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = previous.Username;
            txtPassword.Text = previous.Password;
            txtRole.Text = previous.Role;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MUser updated = new MUser(txtUsername.Text, txtPassword.Text, txtRole.Text);
            MUserDL.editUserFromList(previous, updated);
            this.Close();
        }
    }
}

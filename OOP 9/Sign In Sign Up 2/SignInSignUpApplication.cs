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
    public partial class SignInSignUpApplication : Form
    {
        public SignInSignUpApplication()
        {
            InitializeComponent();
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            MUser c = new MUser(txtUsername.Text, txtPassword.Text);
            MUser flag = MUserDL.SignIn(c);
            if (flag != null)
            {
                MessageBox.Show("Login Successful");
                if (flag.isAdmin() == true)
                {
                    this.Close();
                    UserViewForm ed = new UserViewForm();
                    ed.Show();
                }
            }

            else
            {
                MessageBox.Show("Login Failed");
            }
            ClearDataFromForm();
        }

        private void ClearDataFromForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Visible = false;
        }
    }
}

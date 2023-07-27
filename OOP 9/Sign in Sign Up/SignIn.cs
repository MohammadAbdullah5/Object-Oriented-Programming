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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            SignInSIgnUpApplication s = new SignInSIgnUpApplication();
            s.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Credentials c = new Credentials(txtUsername.Text, txtPassword.Text);
            bool flag = CredentialsDL.login(c);
            if(flag == true)
            {
                MessageBox.Show("Login Successful");
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
    }
}

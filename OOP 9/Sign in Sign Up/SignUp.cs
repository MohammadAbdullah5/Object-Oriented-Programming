using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sign_in_Sign_Up.DL;
using Sign_in_Sign_Up.BL;
using System.Windows.Forms;

namespace Sign_in_Sign_Up
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Credentials info = new Credentials(txtUsername.Text, txtPassword.Text, txtRole.Text);
            CredentialsDL.storeDataInList(info);
            this.Visible = false;
            SignIn s = new SignIn();
            s.Visible = true;
            ClearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            SignInSIgnUpApplication s = new SignInSIgnUpApplication();
            s.Visible = true;
        }

        private void ClearDataFromForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }
    }


}

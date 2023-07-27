using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_in_Sign_Up
{
    public partial class SignInSIgnUpApplication : Form
    {
        public SignInSIgnUpApplication()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (rdBtnSignIn.Checked == true)
            {
                SignIn signin = new SignIn();
                signin.Show();
            }

            else if (rdBtnsignUp.Checked == true)
            {
                SignUp signup = new SignUp();
                signup.Show();
            }
            this.Visible = false;
        }
    }
}

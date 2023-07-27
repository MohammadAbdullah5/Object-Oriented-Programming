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
    public partial class UserViewForm : Form
    {
        private string path = "data.txt";
        public UserViewForm()
        {
            InitializeComponent();
        }

        private void UserViewForm_Load(object sender, EventArgs e)
        {
            MUserDL.readDataFromFile(path);
            usersGV.DataSource = MUserDL.Users;
        }

        public void dataBind()
        {
            usersGV.DataSource = null;
            usersGV.DataSource = MUserDL.Users;
            usersGV.Refresh();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            addUserForm myForm = new addUserForm();
            myForm.ShowDialog();
            MUserDL.storeAllInFile(path);
            dataBind();
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MUser user = (MUser)usersGV.CurrentRow.DataBoundItem;
            if(usersGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                MUserDL.deleteUserFromList(user);
                MUserDL.storeAllInFile(path);
                dataBind();
            }

            if(usersGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditUserForm myForm = new EditUserForm(user);
                myForm.ShowDialog();
                MUserDL.storeAllInFile(path);
                dataBind();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneVanzari
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text=="admin" & tbPassword.Text=="1234")
            {
                MessageBox.Show("Welcome!", "Succes", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK);
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUserName.Text.Trim() ))
            {
                e.Cancel = true;
                epUserName.SetError(tbUserName, "Enter an username");
            }
        }

        private void tbUserName_Validated(object sender, EventArgs e)
        {
            epUserName.Clear();
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text.Trim()))
            {
                e.Cancel = true;
                epPassword.SetError(tbPassword, "Enter a password");
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            epPassword.Clear();
        }
    }
}

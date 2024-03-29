using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddNewAdmin : Form
    {
        public AddNewAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text) ||
                string.IsNullOrWhiteSpace(txtLName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtCnfPassword.Text))
            {
                MessageBox.Show("Enter all mandatory fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPhone.Text.Length != 10)
                {
                    MessageBox.Show("Phone number must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPassword.Text != txtCnfPassword.Text)
                {
                    MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ApplicationDB.userDatas.Add(new UserData(
                        txtFName.Text,
                        txtLName.Text,
                        txtEmail.Text,
                        txtPhone.Text,
                        txtPassword.Text,
                        true)); 

                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
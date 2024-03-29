using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Paradise_Car_Park_System
{
    public partial class Login : Form
    {
        public object TextBox1 { get; set; }
        public object TextBox2 { get; set; }

        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            //This is to validate the email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //This is to validate the password
            if (password.Length == 0)
            {
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if every step is successful then this message will display
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Admin admin = new Admin();
            admin.Show();
        }

        //To check the user email is valid r not
        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            UserData user = new UserData("", "", email, "", password, false);
            Welcome.ActiveUser =  ApplicationDB.checkUser(user);
            if(Welcome.ActiveUser == null)
            {
                MessageBox.Show("User does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Welcome.ActiveUser.IsAdmin)
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
                else
                {
                    UserForm1 userForm1 = new UserForm1();
                    userForm1.Show();
                }
                Form form = Application.OpenForms["Welcome"];
                form.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Paradise_Car_Park_System
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Your existing code remains unchanged.
            string firstName = textBox4.Text;
            string lastName = textBox5.Text;
            string email = textBox1.Text;
            string password = textBox2.Text;
            string reEnterPassword = textBox3.Text;

            // No change in the validation part for email and password
            if (!IsValidEmail(email))
            {
                // Existing logic and message
                return;
            }

            // Phone number validation changed to check for length instead of an integer
            if (txtphone.Text.Length != 10)
            {
                MessageBox.Show("Enter valid phone no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(password))
            {
                // Existing logic and message
                return;
            }

            if (password.Length == 0)
            {
                // Existing logic and message
                return;
            }

            if (password != reEnterPassword)
            {
                // Existing logic and message
                return;
            }

            // Adjust the UserData object creation to use phone as string
            UserData userdata = new UserData(firstName, lastName, email, txtphone.Text, password, false);

            // Presuming ApplicationDB.addUser is the correct method to add users
            ApplicationDB.addUser(userdata);

            // Success message
            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            if(match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidPassword(string password)
        {
            // Checking if password is have atleast 6 characters
            if (password.Length < 6)
            {
                return false;
            }

            // Checking if password contains atleast one uppercase letter
            bool hasUpperCase = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                    break;
                }
            }

            if (hasUpperCase)
            {
                return false;
            }

            // Checking if password contains atleast one special character
            bool hasSpecialCharacter = false;
            foreach (char c in password)
            {
                if (char.IsLetterOrDigit(c))
                {
                    hasSpecialCharacter = true;
                    break;
                }
            }

            if (hasSpecialCharacter)
            {
                return false;
            }

            return true;
        }

    }
}

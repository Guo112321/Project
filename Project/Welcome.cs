using Paradise_Car_Park_System;
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
    public partial class Welcome : Form
    {
        private Form activeForm = null;
        public static UserData ActiveUser = null;
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Home());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Login());
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Signup());
        }

        private void btnDeveloperContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under development", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AboutUs());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActiveUser = null;
            btnLogout.Visible = false;
        }

        /* private void button1_Click(object sender, EventArgs e)
         {

         }*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new Home());
            //ApplicationDB.addUser(new UserData("Gaurang","Dhameliya","abc@gmail.com",1234567890,"abcd",true));
            //ApplicationDB.addUser(new UserData("Arjav","Patel","arjav@gmail.com",0123456789,"abc@123",false));
            ApplicationDB.ReadUserFromOracle();
            ApplicationDB.ReadParkinglotsFromOracle();
            ApplicationDB.ReadVehicleDetailsFromOracle();
            ApplicationDB.ReadTransectionsFromOracle();
        }
    }
}

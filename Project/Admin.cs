using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paradise_Car_Park_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAddParkingLot_Click(object sender, EventArgs e)
        {
            AddParkingLot addParkingLot = new AddParkingLot();
            addParkingLot.Show();
        }

        private void btnViewParkingLot_Click(object sender, EventArgs e)
        {
            ParkingLotStatus parkingLotStatus = new ParkingLotStatus();
            parkingLotStatus.Show();
        }

        private void btnViewTransection_Click(object sender, EventArgs e)
        {
            ViewTransection viewTransection = new ViewTransection();
            viewTransection.Show();
        }

        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            AddNewAdmin addNewAdmin = new AddNewAdmin();
            addNewAdmin.Show();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Form form = Application.OpenForms["Welcome"];
            form.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblUserId.Text = Welcome.ActiveUser.Firstname + " " + Welcome.ActiveUser.Lastname;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["Welcome"];
            form.Show();
            this.Dispose();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
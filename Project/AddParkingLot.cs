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
    public partial class AddParkingLot : Form
    {
        public AddParkingLot()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtLotID.Text == null || txtLocation.Text == null || txtCapacity.Text == null)
            {
                MessageBox.Show("Enter all mendatory fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(ApplicationDB.parkingLots.Any(parkingLot => parkingLot.LotID == txtLotID.Text))
                {
                    MessageBox.Show("Same LotID Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!int.TryParse(txtCapacity.Text, out int phone))
                    {
                        MessageBox.Show("Capacity can only be number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ApplicationDB.parkingLots.Add(new ParkingLot(txtLotID.Text,txtLocation.Text,phone,0));
                    MessageBox.Show("Parking lot added successfully..", "Success",MessageBoxButtons.OK , MessageBoxIcon.Information);
                    txtLotID.Text = "";
                    txtLocation.Text = "";
                    txtCapacity.Text = "";
                }
            }
        }
    }
}
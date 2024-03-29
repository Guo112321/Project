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
    public partial class ParkingLotStatus : Form
    {
        public ParkingLotStatus()
        {
            InitializeComponent();
        }

        public void LoadLotStatus()
        {
            dataGridView1.Rows.Clear();


            foreach (ParkingLot parkinglot in ApplicationDB.parkingLots)
            {
                dataGridView1.Rows.Add(
                   parkinglot.LotID,
                   parkinglot.Location,
                   parkinglot.Capacity,
                   parkinglot.OccupiedSpace
                );

            }
        }

        private void ParkingLotStatus_Load(object sender, EventArgs e)
        {
            LoadLotStatus();
        }
    }
}

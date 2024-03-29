using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Project
{
    public partial class UserEnterParking : Form
    {
        VehicleDetails car;
        ParkingLot selectedParkingLot;
        public UserEnterParking(VehicleDetails car)
        {
            this.car = car;
            InitializeComponent();
        }

        private void UserEnterParking_Load(object sender, EventArgs e)
        {
            cboParkinglots.Items.Clear();
            foreach (ParkingLot i in ApplicationDB.parkingLots)
            {
                cboParkinglots.Items.Add(i.Location);
            }
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            if (cboParkinglots.SelectedItem != null)
            {
                TimeSpan selectedTime = dateTimePicker2.Value.TimeOfDay;

                TransectionDetails transection = new TransectionDetails(
                    ApplicationDB.transectionDetails.Count().ToString(),
                    Welcome.ActiveUser.Email,
                    car.CarNo,
                    selectedParkingLot.LotID,
                    selectedTime,
                    null,
                    dateTimePicker1.Value.Date,
                    0
                    );

                ApplicationDB.transectionDetails.Add(transection);
                string insertTransection = $"INSERT INTO TRANSECTIONDETAILS (TRANSECTIONID, USERID, CARNO, LOTID, STARTINGTIME, ENDINGTIME, TRANSECTIONDATE, FEES) " +
                               $"VALUES ('{transection.TransectionID}', '{transection.UserID}', '{transection.CarNo}', '{transection.LotID}', " +
                               $"'{transection.StartingTime}', null, '{transection.Date}', 0)";

                ApplicationDB.WriteOrUpdateOracle(insertTransection);

                selectedParkingLot.OccupiedSpace++;
                string changeParkinglot = $"UPDATE PARKINGLOTS SET OCCUPIEDSPACE = OCCUPIEDSPACE + 1 WHERE LotID = '{selectedParkingLot.LotID}'"; 
                ApplicationDB.WriteOrUpdateOracle(changeParkinglot);

                car.Status = "Parked";
                string changeCar = $"UPDATE VEHICLEDETAILS SET STATUS = 'Parked' WHERE CarNo = '{car.CarNo}'";
                ApplicationDB.WriteOrUpdateOracle(changeCar);

                btnPark.Enabled = false;
            }
        }

        private void cboParkinglots_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedParkingLot = ApplicationDB.parkingLots[cboParkinglots.SelectedIndex];
        }
    }
}

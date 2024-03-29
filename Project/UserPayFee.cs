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
    public partial class UserPayFee : Form
    {
        VehicleDetails car;
        TransectionDetails transection;
        int fee;
        public UserPayFee(VehicleDetails car)
        {
            InitializeComponent();
            this.car = car;
        }

        private void UserPayFee_Load(object sender, EventArgs e)
        {
            transection = CheckTransection(car);
            dateTimePicker1.Value = DateTime.Today.Add(transection.StartingTime);
            btnPay.Enabled = false;
        }

        private TransectionDetails CheckTransection(VehicleDetails car)
        {
            foreach (var t in ApplicationDB.transectionDetails)
            {
                if (t.CarNo == car.CarNo && t.Fees == 0)
                {
                    return t;
                }
            }
            return null;
        }

        private ParkingLot checkParkinglot(TransectionDetails t)
        {
            foreach (var p in ApplicationDB.parkingLots)
            {
                if(p.LotID == t.LotID)
                {
                    return p;
                }
            }
            return null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan startTime = transection.StartingTime;
            if (dateTimePicker1.Value.TimeOfDay < startTime)
            {
                label1.Text = "Illegal Time!!!";
            }
            else
            {
                label1.Text = "";
                TimeSpan duration = dateTimePicker1.Value.TimeOfDay - startTime;
                double durationInHours = Math.Round(duration.TotalHours, 2);
                fee = Convert.ToInt32(durationInHours * 5);
                btnPay.Text = $"Pay: {fee.ToString("C")}";
                btnPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            TimeSpan endingTime = dateTimePicker1.Value.TimeOfDay;

            transection.EndingTime = endingTime;
            transection.Fees = fee;
            string updateTransection = $"UPDATE TransectionDetails SET EndingTime = '{endingTime}', Fees = {fee} WHERE TransectionID = '{transection.TransectionID}'";
            ApplicationDB.WriteOrUpdateOracle(updateTransection);

            checkParkinglot(transection).OccupiedSpace--;
            string updateParkingLot = $"UPDATE ParkingLots SET OccupiedSpace = OccupiedSpace - 1 WHERE LotID = '{transection.LotID}'";
            ApplicationDB.WriteOrUpdateOracle(updateParkingLot);

            car.Status = "Unparked";
            string updateVehicle = $"UPDATE VehicleDetails SET Status = 'Unparked' WHERE CarNo = '{car.CarNo}'";
            ApplicationDB.WriteOrUpdateOracle(updateVehicle);

            btnPay.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class VehicleDetails
    {
        public string CarNo { get; set; }
        public string UserID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }

        public VehicleDetails(string CarNo, string UserID, string Brand, string Model, string Color, string Status)
        {
            this.CarNo = CarNo;
            this.UserID = UserID;
            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;
            this.Status = Status;
        }
    }
}
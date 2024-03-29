using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ParkingLot
    {
        public string LotID { get; set; }
        public string Location { get; set;}
        public int Capacity { get; set; }
        public int OccupiedSpace { get; set; }

        public ParkingLot(string LotID, string Location, int Capacity, int OccupiedSpace)
        {
            this.LotID = LotID;
            this.Location = Location;
            this.Capacity = Capacity;
            this.OccupiedSpace = OccupiedSpace;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TransectionDetails
    {
        public string TransectionID {  get; set; }
        public string UserID { get; set; }
        public string CarNo { get; set; }
        public string LotID { get; set; }
        public TimeSpan StartingTime { get; set;}
        public TimeSpan? EndingTime { get; set;}
        public DateTime Date {  get; set; }
        public int Fees { get; set; }

        public TransectionDetails(string TransectionID, string UserID, string CarNo, string LotID, TimeSpan StartingTime, TimeSpan? EndingTime, DateTime Date, int Fees)
        {
            this.TransectionID = TransectionID;
            this.UserID = UserID;
            this.CarNo = CarNo;
            this.LotID = LotID;
            this.StartingTime = StartingTime;
            this.EndingTime = EndingTime;
            this.Date = Date;
            this.Fees = Fees;
        }
    }
}
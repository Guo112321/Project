using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class UserDB
    {
        //check the list of car, and find specific user car
        public static List<VehicleDetails> CheckCar(UserData user)
        {
            return ApplicationDB.vehicleDetails
                                .Where(v => v.UserID == user.Email)
                                .ToList();
        }

        public static VehicleDetails CheckCarTransections(string carID)
        {
            // Use LINQ to find the first car that matches the given carID
            return ApplicationDB.vehicleDetails.FirstOrDefault(car => car.CarNo == carID);
        }

    }

}

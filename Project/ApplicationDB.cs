using CsvHelper;
using Oracle.ManagedDataAccess.Client;
using Paradise_Car_Park_System;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Project
{
    public class ApplicationDB
    {
        public static List<UserData> userDatas = new List<UserData>();
        public static List<ParkingLot> parkingLots = new List<ParkingLot>();
        public static List<VehicleDetails> vehicleDetails = new List<VehicleDetails>();
        public static List<TransectionDetails> transectionDetails = new List<TransectionDetails>();
        private static string connectionString = "User Id=N01611988; Password=oracle; Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=calvin.humber.ca)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=grok)));";


        public static void addUser(UserData user)
        {
            userDatas.Add(user);

        }
        public static UserData checkUser(UserData user)
        {
            foreach (UserData u in userDatas)
            {
                if (u.Email == user.Email && u.Password == user.Password)
                {
                    return u;
                }
            }
            return null;
        }
        
        public static void ReadUserFromOracle()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    
                    using(OracleCommand sql = new OracleCommand("SELECT * FROM ACCOUNT", conn))
                    {
                        using(OracleDataReader reader = sql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                bool isAdmin = reader["ISADMIN"].ToString().Equals("T", StringComparison.OrdinalIgnoreCase);

                                userDatas.Add(new UserData(
                                    reader["FIRSTNAME"].ToString(),
                                    reader["LASTNAME"].ToString(),
                                    reader["EMAIL"].ToString(),
                                    reader["PHONENO"].ToString(),
                                    reader["PASSWORD"].ToString(),
                                    isAdmin 
                                ));
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UserDatas: " + ex.Message);
            }
        }

        public static void ReadParkinglotsFromOracle()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand sql = new OracleCommand("SELECT * FROM PARKINGLOTS", conn))
                    {
                        using (OracleDataReader reader = sql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                parkingLots.Add(new ParkingLot(
                                    reader["LOTID"].ToString(),
                                    reader["LOCATION"].ToString(),
                                    Convert.ToInt32(reader["CAPACITY"]),
                                    Convert.ToInt32(reader["OCCUPIEDSPACE"])
                                ));
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parkinglots: " + ex.Message);
            }
        }

        public static void ReadVehicleDetailsFromOracle()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand sql = new OracleCommand("SELECT * FROM VEHICLEDETAILS", conn))
                    {
                        using (OracleDataReader reader = sql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                vehicleDetails.Add(new VehicleDetails(
                                    reader["CARNO"].ToString(),
                                    reader["USERID"].ToString(),
                                    reader["BRAND"].ToString(),
                                    reader["MODEL"].ToString(),
                                    reader["COLOR"].ToString(),
                                    reader["STATUS"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vehcles: " + ex.Message);
            }
        }

        public static void ReadTransectionsFromOracle()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand sql = new OracleCommand("SELECT * FROM TRANSECTIONDETAILS", conn))
                    {
                        using (OracleDataReader reader = sql.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                TimeSpan? endingTime;
                                if (reader["ENDINGTIME"] == DBNull.Value)
                                {
                                    endingTime = null;
                                }
                                else
                                {
                                    endingTime = TimeSpan.Parse(reader["ENDINGTIME"].ToString());
                                }

                                transectionDetails.Add(new TransectionDetails(
                                    Convert.ToString(reader["TRANSACTIONID"]),
                                    Convert.ToString(reader["USERID"]),
                                    Convert.ToString(reader["CARNO"]),
                                    Convert.ToString(reader["LOTID"]),
                                    TimeSpan.Parse(reader["STARTINGTIME"].ToString()),
                                    endingTime,
                                    Convert.ToDateTime(reader["TRANSACTIONDATE"]),
                                    Convert.ToInt32(reader["FEES"])
                                ));
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                return; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transections: " + ex.Message);
            }
        }

        public static void WriteOrUpdateOracle(string command)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand sql = new OracleCommand(command, conn))
                    {
                        sql.CommandType = System.Data.CommandType.Text;
                        sql.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(command,ex.Message);
            }
        }

       
    }
}

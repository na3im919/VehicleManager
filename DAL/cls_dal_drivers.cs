using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_dal_drivers
    {
        static string connectionString = DbConfig.ConnectionString;

        public static List<Models.cls_ml_drivers> GetAllDrivers(out string error)
        {
            var drivers = new List<Models.cls_ml_drivers>();
            error = string.Empty;
            string query = "SELECT driver_id, driver_name FROM drivers WHERE isActive = 1";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var driver = new Models.cls_ml_drivers
                        {
                            driver_id = Convert.ToInt32(reader["driver_id"]),
                            driver_name = reader["driver_name"].ToString(),
                            isActive = true
                        };
                        drivers.Add(driver);
                    }
                    reader.Close();
                    return drivers;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }
        }

        public static int GetDriverIdByName(string driver_name, out string error)
        {
            error = string.Empty;
            int driver_id = -1;
            string query = "SELECT driver_id FROM drivers WHERE driver_name = @driver_name AND isActive = 1";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@driver_name", driver_name);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        driver_id = Convert.ToInt32(result);
                    }
                    return driver_id;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return -1;
                }
            }

           

        }

        public static int AddNewDriver(string driver_name, out string error)
        {
            error = string.Empty;
            int newDriverId = -1;
            string query = "INSERT INTO drivers (driver_name, isActive) OUTPUT INSERTED.driver_id VALUES (@driver_name, 1)";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@driver_name", driver_name);
                try
                {
                    connection.Open();
                    newDriverId = (int)command.ExecuteScalar();
                    return newDriverId;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return -1;
                }
            }
        }

    }
}

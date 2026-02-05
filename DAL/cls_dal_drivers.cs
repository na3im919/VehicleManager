using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_dal_drivers
    {
        static string connectionString  = DbConfig.ConnectionString;

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
    }
}

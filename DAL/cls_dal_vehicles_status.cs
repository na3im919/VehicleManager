using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_dal_vehicles_status
    {
        static string connectionString  = cls_dal_connections.connection;

        public static List<Models.cls_ml_vehicles_status> GetAllVehiclesStatus(out string error)
        { 
            var vehiclesStatus = new List<Models.cls_ml_vehicles_status>();
            error = string.Empty;
            string query = "SELECT * FROM Vehicle_Status";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var status = new Models.cls_ml_vehicles_status
                        {
                            status_id = Convert.ToInt32(reader["status_id"]),
                            status_code = Convert.ToInt32(reader["status_code"]),
                            status_label = reader["status_label"].ToString()
                        };
                        vehiclesStatus.Add(status);
                    }
                    reader.Close();
                    return vehiclesStatus;
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

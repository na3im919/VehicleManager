using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_dal_drivers
    {
        static string connectionString = DbConfig.ConnectionString;

        public static List<Models.cls_ml_drivers> GetAllDrivers(
            string keyword,
            out string error,
            bool isActive)
        {
            var drivers = new List<Models.cls_ml_drivers>();
            error = string.Empty;
            string active = isActive == true ? "1" : "0";
            string query = $@"
        SELECT driver_id, driver_name
        FROM drivers
        WHERE isActive = {active}
        AND (@keyword IS NULL OR driver_name LIKE '%' + @keyword + '%')";
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue(
                    "@keyword",
                    string.IsNullOrWhiteSpace(keyword) ? (object)DBNull.Value : keyword
                );

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        drivers.Add(new Models.cls_ml_drivers
                        {
                            driver_id = Convert.ToInt32(reader["driver_id"]),
                            driver_name = reader["driver_name"].ToString(),
                            isActive = true
                        });
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

        public static cls_ml_drivers GetDriverById(int driver_id, out string error)
        {
            error = string.Empty;
            cls_ml_drivers driver = null;
            string query = "SELECT driver_id, driver_name FROM drivers WHERE driver_id = @driver_id AND isActive = 1";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@driver_id", driver_id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        driver = new cls_ml_drivers
                        {
                            driver_id = Convert.ToInt32(reader["driver_id"]),
                            driver_name = reader["driver_name"].ToString(),
                            isActive = true
                        };
                    }
                    reader.Close();
                    return driver;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
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

        public static bool UpdateDriver(int driver_id, string driver_name, out string error)
        {
            error = string.Empty;
            string query = "UPDATE drivers SET driver_name = @driver_name WHERE driver_id = @driver_id AND isActive = 1";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@driver_id", driver_id);
                command.Parameters.AddWithValue("@driver_name", driver_name);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }

        }

        public static bool DeleteDriver(int driver_id, out string error)
        {
            error = string.Empty;
            string query = "UPDATE drivers SET isActive = 0 WHERE driver_id = @driver_id";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@driver_id", driver_id);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        }

        public static bool ReactivateDriver(int driver_id, out string error)
        {
            error = string.Empty;
            string query = "UPDATE drivers SET isActive = 1 WHERE driver_id = @driver_id";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@driver_id", driver_id);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        }
        }
}

using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class cls_dal_vehicles
    {
        static string connectionString = DbConfig.ConnectionString;

        public static List<cls_ml_vehicles> GetAllVehicles(
    out string error_message,
    string columnName = null,
    string searchText = null)
        {
            error_message = string.Empty;
            var vehicles = new List<cls_ml_vehicles>();

            // الاستعلام الأساسي
            string query = @"SELECT 
                        v.vehicle_id, 
                        v.vehicle_brand, 
                        v.vehicle_number, 
                        p.provider_name, 
                        d.department_name, 
                        dr.driver_name, 
                        vs.status_label, 
                        v.start_date, 
                        v.end_date, 
                        v.observation 
                     FROM Vehicles v 
                     LEFT JOIN Providers p ON v.provider_id = p.provider_id 
                     LEFT JOIN Departments d ON v.department_id = d.department_id 
                     LEFT JOIN Drivers dr ON v.driver_id = dr.driver_id 
                     LEFT JOIN Vehicle_Status vs ON v.status_id = vs.status_id ";

            // إضافة شرط البحث الديناميكي
            if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchText))
            {
                // استخدام LIKE للبحث الجزئي
                query += " WHERE " + columnName + " LIKE '%' + @searchText + '%'";
            }

            query += " ORDER BY v.vehicle_id;";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", searchText);
                        }

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var vehicle = new cls_ml_vehicles
                                {
                                    // --- هنا تم معالجة الخطأ CS1503 ---
                                    // نحصل على فهرس العمود (Ordinal) أولاً، ثم نقرأ القيمة Int
                                    vehicle_id = reader.GetInt32(reader.GetOrdinal("vehicle_id")),

                                    vehicle_brand = reader.IsDBNull(reader.GetOrdinal("vehicle_brand")) ? null : reader.GetString(reader.GetOrdinal("vehicle_brand")),

                                    registration_number = reader.IsDBNull(reader.GetOrdinal("vehicle_number")) ? null : reader.GetString(reader.GetOrdinal("vehicle_number")),

                                    provider_name = reader.IsDBNull(reader.GetOrdinal("provider_name")) ? null : reader.GetString(reader.GetOrdinal("provider_name")),

                                    department_name = reader.IsDBNull(reader.GetOrdinal("department_name")) ? null : reader.GetString(reader.GetOrdinal("department_name")),

                                    driver_name = reader.IsDBNull(reader.GetOrdinal("driver_name")) ? null : reader.GetString(reader.GetOrdinal("driver_name")),

                                    status_label = reader.IsDBNull(reader.GetOrdinal("status_label")) ? "Inconnu" : reader.GetString(reader.GetOrdinal("status_label")),

                                    observation = reader.IsDBNull(reader.GetOrdinal("observation")) ? null : reader.GetString(reader.GetOrdinal("observation")),

                                    // التواريخ
                                    start_date = reader.GetDateTime(reader.GetOrdinal("start_date")),
                                    end_date = reader.IsDBNull(reader.GetOrdinal("end_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("end_date"))
                                };

                                vehicles.Add(vehicle);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                    return null;
                }
            }
            return vehicles;
        }

        public static int GetTotalVehiclesCount(string status, out string error_message)
        {
            error_message = string.Empty;
            int count = 0;
            string query = "SELECT COUNT(*) FROM Vehicles";
            switch (status)
            {
                case "in_service":
                    query += " WHERE status_id = 1";
                    break;
                case "in_repair":
                    query += " WHERE status_id = 2";
                    break;
                case "faulty":
                    query += " WHERE status_id = 3";
                    break;

            }

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        // ExecuteScalar returns the first cell of the first row (the count)
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result);
                        }
                    }
                    return count;
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                    return -1; // Return -1 or 0 to indicate error
                }
            }
        }

        public static int GetInServiceVehiclesCount(out string error_message)
        {
            error_message = string.Empty;
            int count = 0;
            string query = "SELECT COUNT(*) FROM Vehicles WHERE status_id = 1";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        // ExecuteScalar returns the first cell of the first row (the count)
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result);
                        }
                    }
                    return count;
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                    return -1; // Return -1 or 0 to indicate error
                }
            }
        }

        public static cls_ml_vehicles GetVehicleByID(int vehicleID, out string error)
        {
            error = string.Empty;
            cls_ml_vehicles vehicle = null;
            string query = @"SELECT * FROM Vehicles WHERE vehicle_id = @vehicleID";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicleID", vehicleID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                vehicle = new cls_ml_vehicles
                                {
                                    vehicle_id = reader.GetInt32(reader.GetOrdinal("vehicle_id")),
                                    vehicle_brand = reader.IsDBNull(reader.GetOrdinal("vehicle_brand")) ? null : reader.GetString(reader.GetOrdinal("vehicle_brand")),
                                    registration_number = reader.IsDBNull(reader.GetOrdinal("vehicle_number")) ? null : reader.GetString(reader.GetOrdinal("vehicle_number")),
                                    provider_id = reader.GetInt32(reader.GetOrdinal("provider_id")),
                                    department_id = reader.IsDBNull(reader.GetOrdinal("department_id")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("department_id")),
                                    driver_id = reader.IsDBNull(reader.GetOrdinal("driver_id")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("driver_id")),
                                    start_date = reader.GetDateTime(reader.GetOrdinal("start_date")),
                                    end_date = reader.IsDBNull(reader.GetOrdinal("end_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("end_date")),
                                    observation = reader.IsDBNull(reader.GetOrdinal("observation")) ? null : reader.GetString(reader.GetOrdinal("observation")),
                                    status_id = reader.GetInt32(reader.GetOrdinal("status_id"))
                                };
                                return vehicle;
                            }
                            return null; // No vehicle found with the given ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }
        }

        public static int GetVehicleIDByNumber(string vehicleNumber, out string error)
        {
            error = string.Empty;
            int vehicleID = -1;
            string query = "SELECT vehicle_id FROM Vehicles WHERE vehicle_number = @vehicleNumber";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicleNumber", vehicleNumber);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            vehicleID = Convert.ToInt32(result);
                        }
                    }
                    return vehicleID;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return -1; // Indicate error
                }
            }
        }

        public static bool AddNewVehicle(cls_ml_vehicles newVehicle, out string error)
        {
            error = string.Empty;
            string query = @"INSERT INTO Vehicles 
                             (vehicle_brand, vehicle_number, provider_id, department_id, driver_id, start_date, end_date, observation, status_id) 
                             VALUES 
                             (@vehicle_brand, @vehicle_number, @provider_id, @department_id, @driver_id, @start_date, @end_date, @observation, @status_id)";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicle_brand", newVehicle.vehicle_brand ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@vehicle_number", newVehicle.registration_number ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@provider_id", newVehicle.provider_id);
                        command.Parameters.AddWithValue("@department_id", newVehicle.department_id ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@driver_id", newVehicle.driver_id ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@start_date", newVehicle.start_date);
                        command.Parameters.AddWithValue("@end_date", newVehicle.end_date ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@observation", newVehicle.observation ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@status_id", newVehicle.status_id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if insert was successful
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        }

        public static bool UpdateVehicle(int vehicleID, cls_ml_vehicles vehicleToUpdate, out string error)
        {
            error = string.Empty;
            string query = @"UPDATE Vehicles SET 
                             vehicle_brand = @vehicle_brand, 
                             vehicle_number = @vehicle_number, 
                             provider_id = @provider_id, 
                             department_id = @department_id, 
                             driver_id = @driver_id, 
                             start_date = @start_date, 
                             end_date = @end_date, 
                             observation = @observation, 
                             status_id = @status_id 
                             WHERE vehicle_id = @vehicle_id";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicle_brand", vehicleToUpdate.vehicle_brand ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@vehicle_number", vehicleToUpdate.registration_number ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@provider_id", vehicleToUpdate.provider_id);
                        command.Parameters.AddWithValue("@department_id", vehicleToUpdate.department_id ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@driver_id", vehicleToUpdate.driver_id ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@start_date", vehicleToUpdate.start_date);
                        command.Parameters.AddWithValue("@end_date", vehicleToUpdate.end_date ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@observation", vehicleToUpdate.observation ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@status_id", vehicleToUpdate.status_id);
                        command.Parameters.AddWithValue("@vehicle_id", vehicleID);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if update was successful
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }



        }

        public static bool DeleteVehicle(int vehicleID, out string error)
        {
            error = string.Empty;
            string query = "DELETE FROM Vehicles WHERE vehicle_id = @vehicle_id";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicle_id", vehicleID);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if delete was successful
                    }
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

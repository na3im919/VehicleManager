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
        static string connectionString  = cls_dal_connections.connection;

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
                                    end_date = reader.GetDateTime(reader.GetOrdinal("end_date"))
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

    }
}

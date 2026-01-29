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

        public static List<cls_ml_vehicles> GetAllVehicles(out string error_message)
        {
            error_message = string.Empty;

            // تم تحديث الاستعلام ليشمل جدول الحالات ويستخدم الأعمدة الصحيحة
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
                     LEFT JOIN Vehicle_Status vs ON v.status_id = vs.status_id 
                     ORDER BY v.vehicle_id;"; // أو v.vehicle_number حسب التفضيل

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            var vehicles = new List<cls_ml_vehicles>();
                            while (reader.Read())
                            {
                                var vehicle = new cls_ml_vehicles
                                {
                                    // قراءة المعرف (ID)
                                    vehicle_id = reader.GetInt32(reader.GetOrdinal("vehicle_id")),

                                    // قراءة البيانات النصية مع التحقق من NULL
                                    vehicle_brand = reader.IsDBNull(reader.GetOrdinal("vehicle_brand")) ? null : reader.GetString(reader.GetOrdinal("vehicle_brand")),
                                    registration_number = reader.IsDBNull(reader.GetOrdinal("vehicle_number")) ? null : reader.GetString(reader.GetOrdinal("vehicle_number")),

                                    provider_name = reader.IsDBNull(reader.GetOrdinal("provider_name")) ? null : reader.GetString(reader.GetOrdinal("provider_name")),
                                    department_name = reader.IsDBNull(reader.GetOrdinal("department_name")) ? null : reader.GetString(reader.GetOrdinal("department_name")),
                                    driver_name = reader.IsDBNull(reader.GetOrdinal("driver_name")) ? null : reader.GetString(reader.GetOrdinal("driver_name")),

                                    // قراءة الحالة الجديدة
                                    status_label = reader.IsDBNull(reader.GetOrdinal("status_label")) ? "Inconnu" : reader.GetString(reader.GetOrdinal("status_label")),

                                    // قراءة الملاحظات
                                    observation = reader.IsDBNull(reader.GetOrdinal("observation")) ? null : reader.GetString(reader.GetOrdinal("observation")),
                                    start_date = reader.GetDateTime(reader.GetOrdinal("start_date")),
                                    end_date = reader.GetDateTime(reader.GetOrdinal("end_date"))

                                };
                                vehicles.Add(vehicle);
                            }
                            return vehicles;
                        }
                    }
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                    return null;
                }
            }
        }
    }
}

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
            string query = "SELECT v.vehicle_number AS 'N°', v.vehicle_brand AS 'Véhicule', " +
                "v.registration_number AS 'Immatriculation',  p.provider_name AS 'Préstataire'," +
                " d.department_name AS 'Affectation',  dr.driver_name AS 'Service Fait (Conducteur)', " +
                "v.start_date AS 'DATE MISE EN SERVICE',  v.end_date AS 'DATE FIN DE SERVICE', " +
                " v.observation AS 'OBSERVATION' FROM  Vehicles v LEFT JOIN   Providers p ON v.provider_id = p.provider_id LEFT JOIN  " +
                " Departments d ON v.department_id = d.department_id LEFT JOIN   Drivers dr ON v.driver_id = dr.driver_id ORDER BY   v.vehicle_number;";

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
                                    vehicle_id = reader.GetInt32(reader.GetOrdinal("N°")),
                                    vehicle_brand = reader.GetString(reader.GetOrdinal("Véhicule")),
                                    registration_number = reader.GetString(reader.GetOrdinal("Immatriculation")),
                                    provider_name = reader.IsDBNull(reader.GetOrdinal("Préstataire")) ? null : reader.GetString(reader.GetOrdinal("Préstataire")),
                                    department_name = reader.IsDBNull(reader.GetOrdinal("Affectation")) ? null : reader.GetString(reader.GetOrdinal("Affectation")),
                                    driver_name = reader.IsDBNull(reader.GetOrdinal("Service Fait (Conducteur)")) ? null : reader.GetString(reader.GetOrdinal("Service Fait (Conducteur)")),
                                    start_date = reader.GetDateTime(reader.GetOrdinal("DATE MISE EN SERVICE")),
                                    end_date = reader.GetDateTime(reader.GetOrdinal("DATE FIN DE SERVICE"))
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

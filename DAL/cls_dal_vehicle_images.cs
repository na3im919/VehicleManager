using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_dal_vehicle_images
    {
        static string connectionString = DbConfig.ConnectionString;
        public static List<cls_ml_vehicle_image> GetVehcleImagesById(int vehicle_id, out string error)
        {
            var vehicleImages = new List<cls_ml_vehicle_image>();
            error = string.Empty;
            string query = @"SELECT * FROM VehicleImages WHERE vehicle_id = @vehicle_id";


            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicle_id", vehicle_id);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var vehicleImage = new cls_ml_vehicle_image
                                {
                                    ImageID = Convert.ToInt32(reader["image_id"]),
                                    VehicleID = Convert.ToInt32(reader["vehicle_id"]),
                                    ImagePath = reader["image_path"].ToString(),
                                    CreatedAt = Convert.ToDateTime(reader["created_at"])
                                };
                                vehicleImages.Add(vehicleImage);
                            }
                            return vehicleImages;
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

        public static bool AddVehicleNewImage(cls_ml_vehicle_image newImage, out string error)
        {
            error = string.Empty;
            string query = @"INSERT INTO VehicleImages (vehicle_id, image_path, created_at) 
                            VALUES (@vehicle_id, @image_path, @created_at)";
            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicle_id", newImage.VehicleID);
                        command.Parameters.AddWithValue("@image_path", newImage.ImagePath);
                        command.Parameters.AddWithValue("@created_at", DateTime.Now);
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0; // Return true if insert was successful
                    }
                }
                catch (Exception ex)
                {
                    error = "Error adding vehicle image: " + ex.Message;
                    return false;
                }
            }
        }

        public static bool DeleteVehicleImage(int imageId)
        {
            string query = @"DELETE FROM VehicleImages WHERE image_id = @imageId";
            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imageId", imageId);
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0; // Return true if delete was successful
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting vehicle image: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool UpdateVehicleImage(cls_ml_vehicle_image image)
        {
            string query = @"UPDATE VehicleImages
                     SET image_path = @image_path
                     WHERE image_id = @image_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@image_id", SqlDbType.Int).Value = image.ImageID;
                command.Parameters.Add("@image_path", SqlDbType.NVarChar, 255).Value = image.ImagePath;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static List<string> GetVehicleImagePaths(int vehicleID, out string error)
        {
            error = string.Empty;
            var paths = new List<string>();

            string query = "SELECT image_path FROM VehicleImages WHERE vehicle_id = @vehicleID";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@vehicleID", vehicleID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string path = reader["image_path"].ToString();
                                paths.Add(path);
                            }
                            return paths;
                        }
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                        return null;
                    }

                }
            }
        }

        public static string GetVehicleImagePath(int vehicleID, out string error)
        {
            error = string.Empty;

            string query = "SELECT TOP 1 image_path FROM VehicleImages WHERE vehicle_id = @vehicleID";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@vehicleID", vehicleID);
                    connection.Open();

                    var result = command.ExecuteScalar(); // يرجع أول قيمة من الاستعلام
                    return result != null ? result.ToString() : null;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

    }
}

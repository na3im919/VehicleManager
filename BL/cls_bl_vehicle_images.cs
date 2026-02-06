using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class cls_bl_vehicle_images
    {

        public static List<cls_ml_vehicle_image> GetVehcleImagesById(int vehicle_id, out string error)
        {
            return cls_dal_vehicle_images.GetVehcleImagesById(vehicle_id, out error);
        }

        public static bool AddVehicleNewImage(cls_ml_vehicle_image newImage, out string error)
        {
            return cls_dal_vehicle_images.AddVehicleNewImage(newImage, out error);
        }

        public static bool DeleteVehicleImage(int imageId)
        {
            return cls_dal_vehicle_images.DeleteVehicleImage(imageId);
        }

        public static bool UpdateVehicleImage(cls_ml_vehicle_image updatedImage)
        {
            return cls_dal_vehicle_images.UpdateVehicleImage(updatedImage);
        }

    }

    public static class ImageHelper
    {
        public static string CopyToVehicleFolder(
            string rootPath,
            int vehicleId,
            string sourceFile)
        {
            string vehicleFolder =
                Path.Combine(rootPath, "Images", "Vehicles", vehicleId.ToString());

            if (!Directory.Exists(vehicleFolder))
                Directory.CreateDirectory(vehicleFolder);

            string fileName =
                Guid.NewGuid() + Path.GetExtension(sourceFile);

            string destPath = Path.Combine(vehicleFolder, fileName);
            File.Copy(sourceFile, destPath, true);

            return destPath;
        }

        public static void DeleteImage(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }
    }

}

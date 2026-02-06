using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class cls_bl_drivers
    {
        public static List<Models.cls_ml_drivers> GetAllDrivers(string kw, out string error, bool isActive)
        {
            return DAL.cls_dal_drivers.GetAllDrivers(kw, out error, isActive);
        }

        public static int GetDriverIdByName(string driver_name, out string error)
        {
            return DAL.cls_dal_drivers.GetDriverIdByName(driver_name, out error);
        }

        public static cls_ml_drivers GetDriverById(int driver_id, out string error)
        {
            return DAL.cls_dal_drivers.GetDriverById(driver_id, out error);
        }

        public static int AddNewDriver(string newDriver, out string error)
        {
            return DAL.cls_dal_drivers.AddNewDriver(newDriver, out error);
        }

        public static bool UpdateDriver(int driver_id, string driver_name, out string error)
        {
            return cls_dal_drivers.UpdateDriver(driver_id, driver_name, out error);
        }

        public static bool DeleteDriver(int driver_id, out string error)
        {
            return cls_dal_drivers.DeleteDriver(driver_id, out error);
        }

        public static bool ReactivateDriver(int driver_id, out string error)
        {
            return cls_dal_drivers.ReactivateDriver(driver_id, out error);
        }


    }
}

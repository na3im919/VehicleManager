using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BL
{
    public class cls_bl_vehicles
    {
        public static List<cls_ml_vehicles> GetAllVehicles(out string error_message)
        {
            return cls_dal_vehicles.GetAllVehicles(out error_message);
        }

    }
}

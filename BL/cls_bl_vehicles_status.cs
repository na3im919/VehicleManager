using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class cls_bl_vehicles_status
    {
        public static List<Models.cls_ml_vehicles_status> GetAllVehiclesStatus(out string error)
        {
            return cls_dal_vehicles_status.GetAllVehiclesStatus(out error);
        }
    }
}

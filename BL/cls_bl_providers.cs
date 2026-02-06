using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class cls_bl_providers
    {
        public static List<Models.cls_ml_providers> GetAllProviders(out string error)
        {
            return cls_dal_providers.GetAllProviders(out error);
        }

        public static int GetProviderIDByName(string providerName, out string error)
        {
            return cls_dal_providers.GetProviderIDByName(providerName, out error);
        }

        public static int AddNewProvider(string providerName, out string error)
        {
            return cls_dal_providers.AddNewProvider(providerName, out error);
        }

    }
}

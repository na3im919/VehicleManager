using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class cls_bl_providers
    {
        public static List<Models.cls_ml_providers> GetAllProviders(string kw, out string error, bool isActive)
        {
            return cls_dal_providers.GetAllProviders(kw, out error, isActive);
        }

        public static int GetProviderIDByName(string providerName, out string error)
        {
            return cls_dal_providers.GetProviderIDByName(providerName, out error);
        }

        public static cls_ml_providers GetProvidersData(int providerID, out string error)
        {
            return cls_dal_providers.GetProvidersData(providerID, out error);
        }
        public static int AddNewProvider(string providerName, out string error)
        {
            return cls_dal_providers.AddNewProvider(providerName, out error);
        }

        public static bool UpdateProvider(int providerID, string providerName, out string error)
        {
            return cls_dal_providers.UpdateProvider(providerID, providerName, out error);
        }

        public static bool DeactivateProvider(int providerID, out string error)
        {
               return cls_dal_providers.DeactivateProvider(providerID, out error);
        }

        public static bool ActivateProvider(int providerID, out string error)
        {
               return cls_dal_providers.ActivateProvider(providerID, out error);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VehicleManager
{
    public partial class Add_Update_Vehicle : XtraForm
    {
        public Add_Update_Vehicle()
        {
            InitializeComponent();
        }


        bool DataValidation()
        {
            if((string.IsNullOrEmpty(txt_vehicle_name.Text)))
            {
                txt_vehicle_name.ErrorText = "Le remplissage de ce champ est obligatoire.";
                txt_vehicle_name.Focus();
                return false;
            }

            if((string.IsNullOrEmpty(txt_vehicle_number.Text)))
            {
                txt_vehicle_number.ErrorText = "Le remplissage de ce champ est obligatoire.";
                txt_vehicle_number.Focus();
                return false;
            }

            if((string.IsNullOrEmpty(cmb_provider.Text)))
            {
                cmb_provider.ErrorText = "Le remplissage de ce champ est obligatoire.";
                cmb_provider.Focus();
                return false;
            }


            if((string.IsNullOrEmpty(cmb_status.Text)))
            {
                cmb_status.ErrorText = "Le remplissage de ce champ est obligatoire.";
                cmb_status.Focus();
                return false;
            }
            if(date_start_service.DateTime > date_end_service.DateTime)
            {
                XtraMessageBox.Show("La date de début ne peut pas être postérieure à la date de fin.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_start_service.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txt_observation.Text))
            {
                txt_observation.ErrorText = "Le remplissage de ce champ est obligatoire.";
                txt_observation.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(date_start_service.Text))
            {
                date_start_service.ErrorText = "Le remplissage de ce champ est obligatoire.";
                date_start_service.Focus();
                return false;
            }
            return true;
        }

        void LoadProviders()
        {
            string error;
            var providers = BL.cls_bl_providers.GetAllProviders(out error);
            if(providers == null)
            {
                XtraMessageBox.Show("Erreur lors du chargement des fournisseurs : " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmb_provider.Properties.DataSource = providers;
            cmb_provider.Properties.DisplayMember = "provider_name";
            cmb_provider.Properties.ValueMember = "provider_id";
            cmb_provider.Properties.NullText = "-- Sélectionner un Préstataire --"; 
            cmb_provider.Properties.PopulateColumns();
            cmb_provider.Properties.Columns["provider_id"].Visible = false;
            cmb_provider.Properties.Columns["provider_name"].Caption = "";
            cmb_provider.Properties.Columns["isActive"].Visible = false;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_update_Click(object sender, EventArgs e)
        {
            if(!DataValidation())
            {
                return;
            }
        }

        private void Add_Update_Vehicle_Load(object sender, EventArgs e)
        {
            LoadProviders();
        }
    }
}

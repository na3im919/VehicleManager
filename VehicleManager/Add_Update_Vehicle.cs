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
using BL;
using Models;

namespace VehicleManager
{
    public partial class Add_Update_Vehicle : XtraForm
    {
        enum enMode
        {
            Add = 1,
            Update = 2
        }
        public delegate void VehicleListRefreshHandler(string column, string text);
        public event VehicleListRefreshHandler OnVehicleListRefresh;
        enMode Mode;
        int _vehicleID;
        cls_ml_vehicles _currentVehicle;
        public Add_Update_Vehicle()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }

        public Add_Update_Vehicle(int vehicleID)
        {
            InitializeComponent();
            _vehicleID = vehicleID;
            Mode = enMode.Update;
            LoadVehicleData();
            btn_add_update.Text = "Mettre à jour";
            btn_add_update.ImageOptions.SvgImage = Properties.Resources.actions_edit;
        }

        void LoadVehicleData()
        {
            string error;
            _currentVehicle = cls_bl_vehicles.GetVehicleByID(_vehicleID, out error);
            if(_currentVehicle == null)
            {
                XtraMessageBox.Show("Erreur lors du chargement des données du véhicule : " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txt_vehicle_name.Text = _currentVehicle.vehicle_brand;
            txt_vehicle_number.Text = _currentVehicle.registration_number;
            cmb_provider.EditValue = _currentVehicle.provider_id;
            cmb_status.EditValue = _currentVehicle.status_id;
            cmb_department.EditValue = _currentVehicle.department_id;
            cmb_driver.EditValue = _currentVehicle.driver_id;
            date_start_service.DateTime = _currentVehicle.start_date;
            if(_currentVehicle.end_date.HasValue)
            {
                date_end_service.DateTime = _currentVehicle.end_date.Value;
            }
        }

        void AddUpdateVehicle()
        {
            var vehicle = new cls_ml_vehicles()
            {
                vehicle_brand = txt_vehicle_name.Text,
                registration_number = txt_vehicle_number.Text,
                provider_id = Convert.ToInt32(cmb_provider.EditValue),
                status_id = Convert.ToInt32(cmb_status.EditValue),
                department_id = cmb_department.EditValue != null ? Convert.ToInt32(cmb_department.EditValue) : (int?)null,
                driver_id = cmb_driver.EditValue != null ? Convert.ToInt32(cmb_driver.EditValue) : (int?)null,
                start_date = date_start_service.DateTime,
                end_date = !string.IsNullOrEmpty(date_end_service.Text) ? (DateTime?)date_end_service.DateTime : null

            };
            string error;
            bool result = false;
            result = Mode == enMode.Add ? cls_bl_vehicles.AddNewVehicle(vehicle, out error) : cls_bl_vehicles.UpdateVehicle(_vehicleID, vehicle, out error);
            string operation = string.Empty;
            if (result)
            {
                operation = Mode == enMode.Add ? "enregistré" : "mis à jour";
                XtraMessageBox.Show($"Véhicule {operation} avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                operation = Mode == enMode.Add ? "l'enregistrement" : "mis à jour";
                XtraMessageBox.Show($"Erreur lors de {operation} du véhicule : " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            this.Close();
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
            if (date_start_service.DateTime > date_end_service.DateTime && !string.IsNullOrEmpty(date_end_service.Text))
            {
                XtraMessageBox.Show("La date de début ne peut pas être postérieure à la date de fin.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date_start_service.Focus();
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

        void LoadDrivers()
        {
            string error;
            var drivers = cls_bl_drivers.GetAllDrivers(out error);
            if(drivers == null)
            {
                XtraMessageBox.Show("Erreur lors du chargement des conducteurs : " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmb_driver.Properties.DataSource = drivers;
            cmb_driver.Properties.DisplayMember = "driver_name";
            cmb_driver.Properties.ValueMember = "driver_id";
            cmb_driver.Properties.NullText = "-- Sélectionner un Conducteur --"; 
            cmb_driver.Properties.PopulateColumns();
            cmb_driver.Properties.Columns["driver_id"].Visible = false;
            cmb_driver.Properties.Columns["driver_name"].Caption = "";
            cmb_driver.Properties.Columns["isActive"].Visible = false;
            cmb_driver.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
        }

        void LoadStatus()
        {
            string error = string.Empty;
            var status = cls_bl_vehicles_status.GetAllVehiclesStatus(out error);
            if(status == null)
            {
                XtraMessageBox.Show("Erreur lors du chargement des statuts : " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmb_status.Properties.DataSource = status;
            cmb_status.Properties.DisplayMember = "status_label";
            cmb_status.Properties.ValueMember = "status_id";
            cmb_status.Properties.NullText = "-- Sélectionner un Statut --";
            cmb_status.Properties.PopulateColumns();
            cmb_status.Properties.Columns["status_id"].Visible = false;
            cmb_status.Properties.Columns["status_label"].Caption = "";
            cmb_status.Properties.Columns["status_code"].Visible = false;



        }

        void LoadDepartments()
        {
            string error;
            var departments = cls_bl_departments.GetAllDepartments(out error);
            if(departments == null)
            {
                XtraMessageBox.Show("Erreur lors du chargement des départements : " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmb_department.Properties.DataSource = departments;
            cmb_department.Properties.DisplayMember = "department_name";
            cmb_department.Properties.ValueMember = "department_id";
            cmb_department.Properties.NullText = "-- Sélectionner une Affectation --";
            cmb_department.Properties.PopulateColumns();
            cmb_department.Properties.Columns["department_id"].Visible = false;
            cmb_department.Properties.Columns["department_name"].Caption = "";
            cmb_department.Properties.Columns["isActive"].Visible = false;
            cmb_department.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;

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
            AddUpdateVehicle();
            OnVehicleListRefresh?.Invoke("", "");
        }

        private void Add_Update_Vehicle_Load(object sender, EventArgs e)
        {
            LoadProviders();
            LoadDepartments();
            LoadDrivers();
            LoadStatus();
        }
    }
}

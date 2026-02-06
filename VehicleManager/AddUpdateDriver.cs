using BL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManager
{
    public partial class AddUpdateDriver : XtraForm
    {
        enum enMode
        {
            Add,
            Update
        }
        
        enMode Mode;
        int _driverID;

        public AddUpdateDriver()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }

        public AddUpdateDriver(int driverID)
        {
            InitializeComponent();
            var driver = cls_bl_drivers.GetDriverById(driverID, out string error);
            if (!string.IsNullOrEmpty(error))
                XtraMessageBox.Show(error);
            txt_driver_name.Text = driver.driver_name;
            _driverID = driverID;
            Mode = enMode.Update;
            btn_add_update.Text = "Mise à jour";
            btn_add_update.ImageOptions.SvgImage = Properties.Resources.actions_edit;
        }

        void AddUpdateDrivers()
        {
            string operation = Mode == enMode.Add ? "Ajouté" : "Mise a jour";
            string error = string.Empty;
            string driver_name = txt_driver_name.Text;
            switch(Mode)
            {
                case enMode.Add:
                    cls_bl_drivers.AddNewDriver(driver_name, out error);
                    break;
                case enMode.Update:
                    cls_bl_drivers.UpdateDriver(_driverID, driver_name, out error);
                    break;
            }
            if (!string.IsNullOrEmpty(error))
            {
                XtraMessageBox.Show(error);
            }
            else
                XtraMessageBox.Show($"conducteur a {operation} avec succès", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_driver_name.Text))
                return;

            AddUpdateDrivers();


        }
    }
}

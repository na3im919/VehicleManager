using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DevExpress.XtraEditors;

namespace VehicleManager
{
    public partial class DriverManager : XtraForm
    {
        string kw = string.Empty;
        Add_Update_Vehicle add_Update_Vehicle = new Add_Update_Vehicle();
        bool isActive = true;
        public DriverManager()
        {
            InitializeComponent();
        }

        void LoadDriver()
        {
            string error = string.Empty;

            var drivers = cls_bl_drivers.GetAllDrivers(kw, out  error, isActive);
            if (error != string.Empty)
            {
                XtraMessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_drivers.AutoGenerateColumns = false;
            dgv_drivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_drivers.MultiSelect = false;
            dgv_drivers.RowHeadersVisible = false;
           

            if (drivers!= null && drivers.Count > 0)
            {

                if(dgv_drivers.Columns.Count == 0)
                {
                    dgv_drivers.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "driver_id",
                        HeaderText = "ID",
                        Name = "DriverId",
                        Visible = true
                    });

                    dgv_drivers.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "driver_name",
                        HeaderText = "Nom Du Conducteur",
                        Name = "DriverName",
                        Visible = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }
                dgv_drivers.DataSource = drivers;
            }
            else
            {
                dgv_drivers.DataSource = null;
            }

            CountDriversNumber();
        }

        void CountDriversNumber()
        {
            int driversNumber = dgv_drivers.Rows.Count;
            lbl_drivers_number.Text = $"{driversNumber}";
        }
        private void DriverManager_Load(object sender, EventArgs e)
        {
            LoadDriver();
            rad_active_driver.Checked = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            kw = txtSearch.Text.Trim();
            LoadDriver();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddUpdateDriver addDriver = new AddUpdateDriver();
            addDriver.ShowDialog();
            LoadDriver();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(dgv_drivers.SelectedRows.Count > 0)
            {
                int DriverId = Convert.ToInt32(dgv_drivers.SelectedRows[0].Cells["DriverId"].Value);
                AddUpdateDriver updateDriver = new AddUpdateDriver(DriverId);
                updateDriver.ShowDialog();
                LoadDriver();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string operation = isActive == true ? "supprimé" : "Activier";
            if (dgv_drivers.SelectedRows.Count > 0)
            {
                int DriverId = Convert.ToInt32(dgv_drivers.SelectedRows[0].Cells["DriverId"].Value);
                string error = string.Empty;
                if (isActive)
                    cls_bl_drivers.DeleteDriver(DriverId, out error);
                else
                    cls_bl_drivers.ReactivateDriver(DriverId, out error);
              

                if (!string.IsNullOrEmpty(error))
                {
                    XtraMessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show($"Conducteur {operation} avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDriver();
                }
            }
        }

        private void rad_active_driver_CheckedChanged(object sender, EventArgs e)
        {
            isActive = rad_active_driver.Checked;
            label2.Text = "Nombre De Conducteurs Active :";
            btn_add.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Text = "Supprimer";
            btn_delete.ImageOptions.SvgImage = Properties.Resources.actions_deletecircled;
            LoadDriver();
        }

        private void rad_deactivated_drivers_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_deactivated_drivers.Checked)
            {
                btn_add.Enabled = false;
                btn_update.Enabled = false;
                btn_delete.Text = "Activier";
                btn_delete.ImageOptions.SvgImage = Properties.Resources.resetlayoutoptions;
                label2.Text = "Nombre De Conducteurs Supprimè :";
            }
        }
    }
}

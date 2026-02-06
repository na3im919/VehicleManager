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
        public DriverManager()
        {
            InitializeComponent();
        }

        void LoadDriver()
        {
            string error = string.Empty;

            var drivers = cls_bl_drivers.GetAllDrivers(kw, out  error);
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


        }
        private void DriverManager_Load(object sender, EventArgs e)
        {
            LoadDriver();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            kw = txtSearch.Text.Trim();
            LoadDriver();
        }
    }
}

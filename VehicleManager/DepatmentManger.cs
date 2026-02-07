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
    public partial class DepatmentManger : XtraForm
    {
        enum enMode { add, update }
        enMode Mode;

        int _departmentID;
        bool isActive = true;
        string kw;

        public DepatmentManger()
        {
            InitializeComponent();
            Mode = enMode.add;
        }

        public DepatmentManger(int departmentID)
        {
            InitializeComponent();
            _departmentID = departmentID;
            Mode = enMode.update;
        }

        private void InitDepartmentsGrid()
        {
            dgv_departments.AutoGenerateColumns = false;
            dgv_departments.Columns.Clear();

            dgv_departments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "department_id",
                Name = "ID",
                HeaderText = "ID"
            });

            dgv_departments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "department_name",
                Name = "DepartmentName",
                HeaderText = "Affectation",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        void LoadDepartments()
        {
            string error = string.Empty;
            var Departments = cls_bl_departments.GetAllDepartments(kw, isActive, out error);

            if (!string.IsNullOrEmpty(error))
            {
                XtraMessageBox.Show(error);
                return;
            }

            if (Departments != null && Departments.Count > 0)
            {
                dgv_departments.DataSource = Departments;
            }
            else
            {
                dgv_departments.DataSource = null;
            }
            DepartmentCounter();
        }

        void DepartmentCounter()
        {
            int departmentCounter = dgv_departments.Rows.Count;
            lbl_departments_number.Text = departmentCounter.ToString();
        }

        private void rad_active_affectation_CheckedChanged(object sender, EventArgs e)
        {
            isActive = true;
            if(isActive)
            {
                label2.Text = "Nombre D'Affectations Active : ";
                btn_add.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Text = "Supprimer";
                btn_delete.ImageOptions.SvgImage = Properties.Resources.actions_deletecircled1;
            }
            LoadDepartments();
        }

        private void rad_deactivated_affectation_CheckedChanged(object sender, EventArgs e)
        {
            isActive = false;
            if(!isActive)
            {
                label2.Text = "Nombre D'Affectations supprimé :";
                btn_update.Enabled = false;
                btn_add.Enabled = false;
                btn_delete.Text = "Activier";
                btn_delete.ImageOptions.SvgImage = Properties.Resources.resetlayoutoptions;
            }
            LoadDepartments();
        }

        private void DepatmentManger_Load(object sender, EventArgs e)
        {
            rad_active_affectation.Checked = true;
            InitDepartmentsGrid();
            LoadDepartments();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            kw = txtSearch.Text;
            LoadDepartments();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string operation = isActive ? "Supprimer" : "Activer";

            switch (isActive)
            {
                case true:
                    if (XtraMessageBox.Show($"Êtes-vous sûr de vouloir {operation} ce affectation ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string error = string.Empty;
                        int providerId = Convert.ToInt32(dgv_departments.CurrentRow.Cells["ID"].Value);
                        bool success = BL.cls_bl_departments.DeleteDepartment(providerId, out error);
                        if (success)
                        {
                            XtraMessageBox.Show("Affectation supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDepartments();
                        }
                        else
                        {
                            XtraMessageBox.Show(error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case false:
                    if (XtraMessageBox.Show($"Êtes-vous sûr de vouloir {operation} ce prestataire?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string error = string.Empty;
                        int providerId = Convert.ToInt32(dgv_departments.CurrentRow.Cells["ID"].Value);
                        bool success = BL.cls_bl_departments.ReactivateDepartment(providerId, out error);
                        if (success)
                        {
                            XtraMessageBox.Show("Prestataire activé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDepartments();
                        }
                        else
                        {
                            XtraMessageBox.Show(error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddUpdateDepartment add_depatment = new AddUpdateDepartment();
            add_depatment.ShowDialog();
            LoadDepartments();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt32(dgv_departments.SelectedRows[0].Cells["ID"].Value);
            AddUpdateDepartment update_department = new AddUpdateDepartment(departmentID);
            update_department.ShowDialog();
            LoadDepartments();
        }
    }
}

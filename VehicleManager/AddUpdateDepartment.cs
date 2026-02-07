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
    public partial class AddUpdateDepartment : XtraForm
    {
        enum enMode
        {
            add, update
        }
        enMode Mode;
        int _departmentID;
        public AddUpdateDepartment()
        {
            InitializeComponent();
            Mode = enMode.add;
            this.Text = "Ajouter Affectation";
        }

        public AddUpdateDepartment(int departmentID)
        {
            InitializeComponent();
            Mode = enMode.update;
            _departmentID = departmentID;
            this.Text = "Modifier Affectation";
            txt_department.Text = cls_bl_departments.GetDepartmentName(_departmentID, out string error);
            if (!string.IsNullOrEmpty(error))
                XtraMessageBox.Show(error);
        }

        void AddUpdateDepartments()
        {
            string operation = Mode == enMode.add ? "Ajouté" : "Mise a jour";
            string error = string.Empty;
            string department_name = txt_department.Text;
            switch (Mode)
            {
                case enMode.add:
                    cls_bl_departments.AddNewDepartment(department_name, out error);
                    break;
                case enMode.update:
                    cls_bl_departments.UpdateDepartment(_departmentID, department_name, out error);
                    break;
            }
            if (!string.IsNullOrEmpty(error))
            {
                XtraMessageBox.Show(error);
            }
            else
                XtraMessageBox.Show($"Affectation a {operation} avec succès", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_update_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_department.Text))
            {
                txt_department.ErrorText = "Champ obligatoire !";
                txt_department.Focus();
                return;
            }
            AddUpdateDepartments();
        }
    }
}

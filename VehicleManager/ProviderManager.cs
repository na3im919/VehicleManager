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
    public partial class ProviderManager : XtraForm
    {
        enum enMode
        {
            Add,
            Update
        }

        enMode Mode;

        int _providerId;
        string kw = string.Empty;
        bool _isActive;
        public ProviderManager()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }

        public ProviderManager(int providerId)
        {
            InitializeComponent();
            _providerId = providerId;
            Mode = enMode.Update;
        }

        void LoadProviderData()
        {
            string error = string.Empty;
            var providerData = BL.cls_bl_providers.GetAllProviders(kw, out error,_isActive);
            dgv_providers.AutoGenerateColumns = false;
            if (error != string.Empty)
            {
                XtraMessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (providerData != null && providerData.Count > 0)
            {
                dgv_providers.DataSource = providerData;
                if (dgv_providers.Columns.Count == 0)
                {
                    dgv_providers.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "ID",
                        DataPropertyName = "provider_id",
                        HeaderText = "ID",
                        Visible = true


                    });

                    dgv_providers.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Name",
                        DataPropertyName = "provider_name",
                        HeaderText = "Nom Du Préstataire",
                        Visible = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


                    });

                }
               
            }

            else
            {
                dgv_providers.DataSource = null;
                dgv_providers.Rows.Clear();
            }


        }

        private void ProviderManager_Load(object sender, EventArgs e)
        {
           LoadProviderData();
            rad_active_provider.Checked = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            kw = txtSearch.Text.Trim();
            LoadProviderData();
        }

        private void rad_active_provider_CheckedChanged(object sender, EventArgs e)
        {
            _isActive = rad_active_provider.Checked;
            if(_isActive)
            {
                btn_delete.Text = "Supprimer";
                btn_delete.ImageOptions.SvgImage = Properties.Resources.actions_deletecircled;
                btn_add.Enabled = true;
                btn_update.Enabled = true;
            }
           
            LoadProviderData();
        }

        private void rad_deactivated_provider_CheckedChanged(object sender, EventArgs e)
        {
            _isActive = !rad_deactivated_provider.Checked;
            if(!_isActive)
            {
                btn_delete.Text = "Activer";
                btn_delete.ImageOptions.SvgImage = Properties.Resources.resetlayoutoptions;
                btn_add.Enabled = false;
                btn_update.Enabled = false;
            }
            LoadProviderData();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string operation = _isActive ? "Supprimer" : "Activer";

            switch(_isActive)
            {
                case true:
                    if (XtraMessageBox.Show($"Êtes-vous sûr de vouloir {operation} ce prestataire?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string error = string.Empty;
                        int providerId = Convert.ToInt32(dgv_providers.CurrentRow.Cells["ID"].Value);
                        bool success = BL.cls_bl_providers.DeactivateProvider(providerId, out error);
                        if (success)
                        {
                            XtraMessageBox.Show("Prestataire supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProviderData();
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
                        int providerId = Convert.ToInt32(dgv_providers.CurrentRow.Cells["ID"].Value);
                        bool success = BL.cls_bl_providers.ActivateProvider(providerId, out error);
                        if (success)
                        {
                            XtraMessageBox.Show("Prestataire activé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProviderData();
                        }
                        else
                        {
                            XtraMessageBox.Show(error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_providers.SelectedRows.Count > 0)
            {
                int providerID = Convert.ToInt32(dgv_providers.SelectedRows[0].Cells["ID"].Value);
                AddUpdateProvider updateProvider = new AddUpdateProvider(providerID);
                updateProvider.ShowDialog();
                LoadProviderData();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddUpdateProvider addprovider = new AddUpdateProvider();
            addprovider.ShowDialog();
            LoadProviderData();
        }
    }
}

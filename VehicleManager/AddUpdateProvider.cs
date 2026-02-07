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
    public partial class AddUpdateProvider : Form
    {
        int _providerId;
        enum enMode { add, update }
        enMode Mode;
        public AddUpdateProvider()
        {
            InitializeComponent();
        }

        public AddUpdateProvider(int providerId)
        {
            InitializeComponent();
            _providerId = providerId;

            var provider = cls_bl_providers.GetProvidersData(_providerId, out string error);
            if (!string.IsNullOrEmpty(error))
            {
                XtraMessageBox.Show(error);
                return;
            }
            txt_provider.Text = provider.provider_name;

            Mode = enMode.update;
            this.Text = "Modifier Préstataire";
            btn_add_update.Text = "Mise a jour";
            btn_add_update.ImageOptions.SvgImage = Properties.Resources.actions_edit;
        }

        void AddUpdateProviders()
        {
            string operation = Mode == enMode.add ? "Ajouté" : "Mise a jour";
            string error = string.Empty;
            string provider_name = txt_provider.Text;
            switch (Mode)
            {
                case enMode.add:
                    cls_bl_providers.AddNewProvider(provider_name, out error);
                    break;
                case enMode.update:
                    cls_bl_providers.UpdateProvider(_providerId, provider_name, out error);
                    break;
            }
            if (!string.IsNullOrEmpty(error))
            {
                XtraMessageBox.Show(error);
            }
            else
                XtraMessageBox.Show($"Préstataire a {operation} avec succès", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_add_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_provider.Text))
                return;
            AddUpdateProviders();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

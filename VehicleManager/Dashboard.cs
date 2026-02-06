using BL;
using DevExpress.DataProcessing;
using DevExpress.Map.Kml.Model;
using DevExpress.XtraEditors;
using Models;
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
    public partial class Dashboard : XtraForm
    {
        List<string> labelsList = new List<string>()
        {
            "lbl_all_vehicles",
            "lbl_vehicles_on_service",
            "lbl_veicles_in_repair",
            "lbl_faulty_vehicles"
        };
        public Dashboard()
        {
            InitializeComponent();
        }

        public void DashboardCardsRefresh()
        {
            var allVehiclesCounter = new vehiclesCountingUpdater(lbl_all_vehicles);
            var inServiceVehiclesCounter = new vehiclesCountingUpdater(lbl_vehicles_on_service);
            var inRepairVehiclesCounter = new vehiclesCountingUpdater(lbl_veicles_in_repair);
            var faulty_VehiclesCounter = new vehiclesCountingUpdater(lbl_faulty_vehicles);
            string error = string.Empty;
            Subscribe(allVehiclesCounter);
            Subscribe(inServiceVehiclesCounter);
            Subscribe(inRepairVehiclesCounter);
            Subscribe(faulty_VehiclesCounter);
            int allVehiclesCount = cls_bl_vehicles.GetTotalVehiclesCount("", out error);
            int inServiceVehiclesCount = cls_bl_vehicles.GetTotalVehiclesCount("in_service", out error);
            int in_repairVehiclesCounter = cls_bl_vehicles.GetTotalVehiclesCount("in_repair", out error);
            int faltyVehiclesCounter = cls_bl_vehicles.GetTotalVehiclesCount("faulty", out error);
            if (!string.IsNullOrEmpty(error))
                XtraMessageBox.Show(error);
            if (allVehiclesCount != -1)
                allVehiclesCounter.OnvehiclesCountingChanged(allVehiclesCount);
            if (inServiceVehiclesCount != -1)
                inServiceVehiclesCounter.OnvehiclesCountingChanged(inServiceVehiclesCount);
            if (in_repairVehiclesCounter != -1)
                inRepairVehiclesCounter.OnvehiclesCountingChanged(in_repairVehiclesCounter);

            if (faltyVehiclesCounter != -1)
                faulty_VehiclesCounter.OnvehiclesCountingChanged(faltyVehiclesCounter);
        }
        public void LoadVehicles(string column = null, string text = null)
        {
            // تعريف متغير لتلقي رسائل الخطأ
            string error_message = string.Empty;

            // 1. استدعاء دالة جلب البيانات
            var vehiclesList = cls_bl_vehicles.GetAllVehicles(out error_message, column, text);

            // 2. التحقق من وجود أخطاء
            if (!string.IsNullOrEmpty(error_message))
            {
                MessageBox.Show("Error: " + error_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. إعداد الـ DataGridView
            // من الأفضل إيقاف الإنشاء التلقائي للأعمدة للتحكم في العناوين (Headers)
            dgv_vehicles.AutoGenerateColumns = false;

            // تفريغ البيانات القديمة قبل الإضافة الجديدة
            dgv_vehicles.DataSource = null;

            if (vehiclesList != null && vehiclesList.Count > 0)
            {
                // ربط القائمة بالجدول
                dgv_vehicles.DataSource = vehiclesList;

                dgv_vehicles.AllowUserToOrderColumns = true;
                // 4. تعريف الأعمدة (Columns Mapping)
                // إذا لم تكن الأعمدة موجودة مسبقاً، نقوم بإنشائها
                if (dgv_vehicles.Columns.Count == 0)
                {
                    // N° (استخدمنا vehicle_number لأنه الرقم الظاهر في Excel)
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "vehicle_id", // اسم العمود في DataGridView
                        DataPropertyName = "vehicle_id",
                        HeaderText = "N°",
                        Width = 50,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                        SortMode = DataGridViewColumnSortMode.Automatic

                    });

                    // Véhicule
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "vehicle_brand",
                        HeaderText = "Véhicule",
                        Width = 120,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    });

                    // Immatriculation
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "registration_number",
                        HeaderText = "Immatriculation",
                        Width = 120,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    });

                    // Préstataire
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "provider_name",
                        HeaderText = "Préstataire",
                        Width = 150,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    });

                    // Affectation
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "department_name",
                        HeaderText = "Affectation",
                        Width = 120,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                    });

                    // Service Fait (Conducteur)
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "driver_name",
                        HeaderText = "Service Fait (Conducteur)",
                        Width = 180,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    });

                    // DATE MISE EN SERVICE
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "start_date",
                        HeaderText = "DATE MISE EN SERVICE",
                        Width = 120,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        // ملاحظة: إذا أردت تنسيق التاريخ (yyyy/MM/dd) يمكنك إضافة:
                        // DataGridViewCellStyle = new DataGridViewCellStyle() { Format = "yyyy/MM/dd" }
                    });

                    // DATE FIN DE SERVICE
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "end_date",
                        HeaderText = "DATE FIN DE SERVICE",
                        Width = 120,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    });

                    // STATUS
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "status_label",
                        HeaderText = "STATUS",
                        Width = 100,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    });

                    // OBSERVATION
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "observation",
                        HeaderText = "OBSERVATION",
                        Width = 300,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgv_vehicles.Columns.Add(new DataGridViewImageColumn 
                    { 
                        Name = "status_image", 
                        DataPropertyName = "status_image", 
                        HeaderText = "", 
                        Width = 50, 
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, 
                        ImageLayout = DataGridViewImageCellLayout.Zoom ,
                        Image = Properties.Resources.specification // تأكد من إضافة صورة status_icon إلى موارد المشروع (Resources)
                    });


                }
            }
            else
            {
                // في حالة عدم وجود بيانات
                dgv_vehicles.DataSource = null;
            }
            DashboardCardsRefresh();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

            LoadVehicles();
            cmbSearchField.SelectedIndex = 0;

        }

        public void Subscribe(vehiclesCountingUpdater updater)
        {
            updater.vehiclesCountingChanged += OnvehiclesCountingChanged;
        }

        public void OnvehiclesCountingChanged(object sender, vehiclesCountingChangedEventArgs e)
        {
            switch (e.label_name)
            {
                case "lbl_all_vehicles":
                    lbl_all_vehicles.Text = e.currentCounting.ToString();
                    break;
                case "lbl_vehicles_on_service":
                    lbl_vehicles_on_service.Text = e.currentCounting.ToString();
                    break;
                case "lbl_veicles_in_repair":
                    lbl_veicles_in_repair.Text = e.currentCounting.ToString();
                    break;
                case "lbl_faulty_vehicles":
                    lbl_faulty_vehicles.Text = e.currentCounting.ToString();
                    break;
                default:
                    break;
            }
        }

        // حدث عند تغيير النص في مربع البحث
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string selectedColumn = "";

            // تحديد اسم العمود بناءً على اختيار المستخدم في الـ ComboBox
            // يجب أن تتطابق النصوص هنا مع ما يختاره المستخدم بدقة
            switch (cmbSearchField.Text)
            {
                case "Préstataire":
                    selectedColumn = "p.provider_name";
                    break;
                case "Service Fait (Conducteur)":
                    // السائق في الجدول باسم dr.driver_name
                    selectedColumn = "dr.driver_name";
                    break;
                case "Véhicule":
                    selectedColumn = "v.vehicle_brand"; // استخدام Backticks إذا كانت الكلمات محجوزة في بعض الأنظمة، أو v.vehicle_brand مباشرة
                    break;
                case "Immatriculation":
                    selectedColumn = "v.vehicle_number";
                    break;
                case "Affectation":
                    selectedColumn = "d.department_name";
                    break;
                case "Status":
                    selectedColumn = "vs.status_label";
                    break;
                case "DATE MISE EN SERVICE":
                    selectedColumn = "v.start_date";
                    break;
                case "DATE FIN DE SERVICE":
                    selectedColumn = "v.end_date";
                    break;
                // ... يمكنك إضافة باقي الحالات
                default:
                    selectedColumn = ""; // إذا لم يتم اختيار شيء، لا يوجد بحث
                    string filterValue = txtSearch.Text;
                    break;
            }

            // استدعاء دالة التحميل مع تمرير العمود والنص
            LoadVehicles(selectedColumn, txtSearch.Text);
        }

        private void cmbSearchField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch_TextChanged(sender, e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Update_Vehicle addVehicleForm = new Add_Update_Vehicle();
            addVehicleForm.OnVehicleListRefresh += LoadVehicles;
            addVehicleForm.ShowDialog();
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_vehicles.SelectedRows.Count > 0)
            {
                int vehicle_id = Convert.ToInt32(dgv_vehicles.SelectedRows[0].Cells["vehicle_id"].Value);
                Add_Update_Vehicle updateVehicleForm = new Add_Update_Vehicle(vehicle_id);
                updateVehicleForm.OnVehicleListRefresh += LoadVehicles;
                updateVehicleForm.ShowDialog();
                txtSearch.Clear();
                txtSearch.Focus();
            }
            return;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Etes-vous sûr de vouloir supprimer le véhicule sélectionné?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgv_vehicles.SelectedRows.Count > 0)
                {
                    int vehicle_id = Convert.ToInt32(dgv_vehicles.SelectedRows[0].Cells["vehicle_id"].Value);
                    string error = string.Empty;
                    bool isDeleted = cls_bl_vehicles.DeleteVehicle(vehicle_id, out error);
                    if (!isDeleted)
                    {
                        XtraMessageBox.Show("Erreur lors de la suppression du véhicule: " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        XtraMessageBox.Show("Véhicule supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadVehicles();
                        txtSearch.Clear();
                        txtSearch.Focus();
                    }
                }
            }
        }

        private void btn_import_xl_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Sélectionner un fichier Excel";
                ofd.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string error;
                    int rowsNumber;
                    if(!cls_bl_vehicles.ImportVehiclesFromExcel(ofd.FileName, out error, out rowsNumber))
                    {
                        MessageBox.Show("Erreur lors de l'importation: " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show($"Importation terminée avec succès ✅ {rowsNumber} nouvelle véhicule a ajouter");
                    LoadVehicles();
                }
            }
        }

        private void exporterVideFicherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Exporter un modèle Excel";
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = "Vehicles_Template.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string error;
                    cls_bl_vehicles.ExportEmptyVehiclesExcel(sfd.FileName, out error);

                    if (string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Fichier Excel créé avec succès ✅");
                    }
                    else
                    {
                        MessageBox.Show(error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgv_vehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // اسم عمود الصور
            if (dgv_vehicles.Columns[e.ColumnIndex].Name == "status_image")
            {
                int vehicleId = Convert.ToInt32(
                    dgv_vehicles.Rows[e.RowIndex].Cells["vehicle_id"].Value
                );

                VehicleImages frm = new VehicleImages(vehicleId);
                frm.ShowDialog();
            }
        }
    }




    public class vehiclesCountingUpdater
    {
        public EventHandler<vehiclesCountingChangedEventArgs> vehiclesCountingChanged;
        public int currentCounting { get; set; }
        public Label label;
        public vehiclesCountingUpdater(Label label)
        {
            this.label = label;
            this.currentCounting = Convert.ToInt32(label.Text);

        }
        public void OnvehiclesCountingChanged(int newVehiclesCounting)
        {
            if (newVehiclesCounting != currentCounting)
            {
                currentCounting = newVehiclesCounting;
                OnVehiclesCountingChanged(new vehiclesCountingChangedEventArgs(currentCounting, label.Name));
            }

        }

        protected virtual void OnVehiclesCountingChanged(vehiclesCountingChangedEventArgs e)
        {
            vehiclesCountingChanged?.Invoke(this, e);
        }
    }
}



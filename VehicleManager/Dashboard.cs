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
            var vehiclesList = cls_bl_vehicles.GetAllVehicles( out error_message, column, text);

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

                // 4. تعريف الأعمدة (Columns Mapping)
                // إذا لم تكن الأعمدة موجودة مسبقاً، نقوم بإنشائها
                if (dgv_vehicles.Columns.Count == 0)
                {
                    // N° (استخدمنا vehicle_number لأنه الرقم الظاهر في Excel)
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "vehicle_id",
                        HeaderText = "N°",
                        Width = 50
                    });

                    // Véhicule
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "vehicle_brand",
                        HeaderText = "Véhicule",
                        Width = 120
                    });

                    // Immatriculation
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "registration_number",
                        HeaderText = "Immatriculation",
                        Width = 120
                    });

                    // Préstataire
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "provider_name",
                        HeaderText = "Préstataire",
                        Width = 150
                    });

                    // Affectation
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "department_name",
                        HeaderText = "Affectation",
                        Width = 120
                    });

                    // Service Fait (Conducteur)
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "driver_name",
                        HeaderText = "Service Fait (Conducteur)",
                        Width = 180
                    });

                    // DATE MISE EN SERVICE
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "start_date",
                        HeaderText = "DATE MISE EN SERVICE",
                        Width = 120
                        // ملاحظة: إذا أردت تنسيق التاريخ (yyyy/MM/dd) يمكنك إضافة:
                        // DataGridViewCellStyle = new DataGridViewCellStyle() { Format = "yyyy/MM/dd" }
                    });

                    // DATE FIN DE SERVICE
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "end_date",
                        HeaderText = "DATE FIN DE SERVICE",
                        Width = 120
                    });

                    // STATUS
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "status_label",
                        HeaderText = "STATUS",
                        Width = 100
                    });

                    // OBSERVATION
                    dgv_vehicles.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "observation",
                        HeaderText = "OBSERVATION",
                        Width = 200,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });


                }
            }
            else
            {
                // في حالة عدم وجود بيانات
                dgv_vehicles.DataSource = null;
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            DashboardCardsRefresh();
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
            addVehicleForm.ShowDialog();
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
        if(newVehiclesCounting != currentCounting)
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



using BL;
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
        public Dashboard()
        {
            InitializeComponent();
        }

        public void LoadVehicles()
        {
            // تعريف متغير لتلقي رسائل الخطأ
            string error_message = string.Empty;

            // 1. استدعاء دالة جلب البيانات
            var vehiclesList = cls_bl_vehicles.GetAllVehicles(out error_message);

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
                        Width = 200
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
            LoadVehicles();
        }
    }
}

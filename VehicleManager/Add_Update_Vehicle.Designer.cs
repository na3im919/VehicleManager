namespace VehicleManager
{
    partial class Add_Update_Vehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Update_Vehicle));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txt_vehicle_name = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_vehicle_number = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmb_provider = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmb_departement = new DevExpress.XtraEditors.LookUpEdit();
            this.cmb_driver = new DevExpress.XtraEditors.LookUpEdit();
            this.date_start_service = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.date_end_service = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmb_status = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_observation = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_add_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vehicle_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vehicle_number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_provider.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_departement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_driver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start_service.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start_service.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end_service.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end_service.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_vehicle_name);
            this.layoutControl1.Controls.Add(this.txt_vehicle_number);
            this.layoutControl1.Controls.Add(this.cmb_provider);
            this.layoutControl1.Controls.Add(this.cmb_departement);
            this.layoutControl1.Controls.Add(this.cmb_driver);
            this.layoutControl1.Controls.Add(this.date_start_service);
            this.layoutControl1.Controls.Add(this.date_end_service);
            this.layoutControl1.Controls.Add(this.cmb_status);
            this.layoutControl1.Controls.Add(this.txt_observation);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1271, 372);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1271, 372);
            this.Root.TextVisible = false;
            // 
            // txt_vehicle_name
            // 
            this.txt_vehicle_name.Location = new System.Drawing.Point(228, 14);
            this.txt_vehicle_name.Name = "txt_vehicle_name";
            this.txt_vehicle_name.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicle_name.Properties.Appearance.Options.UseFont = true;
            this.txt_vehicle_name.Size = new System.Drawing.Size(1029, 30);
            this.txt_vehicle_name.StyleController = this.layoutControl1;
            this.txt_vehicle_name.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txt_vehicle_name;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem1.Text = "Véhicle";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(199, 23);
            // 
            // txt_vehicle_number
            // 
            this.txt_vehicle_number.Location = new System.Drawing.Point(228, 48);
            this.txt_vehicle_number.Name = "txt_vehicle_number";
            this.txt_vehicle_number.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicle_number.Properties.Appearance.Options.UseFont = true;
            this.txt_vehicle_number.Size = new System.Drawing.Size(1029, 30);
            this.txt_vehicle_number.StyleController = this.layoutControl1;
            this.txt_vehicle_number.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txt_vehicle_number;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem2.Text = "Immatriculation";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(199, 23);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.cmb_provider;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem3.Text = "Préstataire";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(199, 23);
            // 
            // cmb_provider
            // 
            this.cmb_provider.Location = new System.Drawing.Point(228, 82);
            this.cmb_provider.Name = "cmb_provider";
            this.cmb_provider.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_provider.Properties.Appearance.Options.UseFont = true;
            this.cmb_provider.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_provider.Properties.NullText = "";
            this.cmb_provider.Properties.PopupSizeable = false;
            this.cmb_provider.Size = new System.Drawing.Size(1029, 30);
            this.cmb_provider.StyleController = this.layoutControl1;
            this.cmb_provider.TabIndex = 6;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.cmb_departement;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem4.Text = "Affectation";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(199, 23);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.cmb_driver;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem5.Text = "Service Fait (Conducteur)\"";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(199, 23);
            // 
            // cmb_departement
            // 
            this.cmb_departement.Location = new System.Drawing.Point(228, 116);
            this.cmb_departement.Name = "cmb_departement";
            this.cmb_departement.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_departement.Properties.Appearance.Options.UseFont = true;
            this.cmb_departement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_departement.Properties.NullText = "";
            this.cmb_departement.Properties.PopupSizeable = false;
            this.cmb_departement.Size = new System.Drawing.Size(1029, 30);
            this.cmb_departement.StyleController = this.layoutControl1;
            this.cmb_departement.TabIndex = 7;
            // 
            // cmb_driver
            // 
            this.cmb_driver.Location = new System.Drawing.Point(228, 150);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_driver.Properties.Appearance.Options.UseFont = true;
            this.cmb_driver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_driver.Properties.NullText = "";
            this.cmb_driver.Properties.PopupSizeable = false;
            this.cmb_driver.Size = new System.Drawing.Size(1029, 30);
            this.cmb_driver.StyleController = this.layoutControl1;
            this.cmb_driver.TabIndex = 8;
            // 
            // date_start_service
            // 
            this.date_start_service.EditValue = null;
            this.date_start_service.Location = new System.Drawing.Point(228, 184);
            this.date_start_service.Name = "date_start_service";
            this.date_start_service.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_start_service.Properties.Appearance.Options.UseFont = true;
            this.date_start_service.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_start_service.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_start_service.Size = new System.Drawing.Size(1029, 30);
            this.date_start_service.StyleController = this.layoutControl1;
            this.date_start_service.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.date_start_service;
            this.layoutControlItem6.CustomizationFormText = "DATE MISE EN SERVICE";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 170);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem6.Text = "DATE MISE EN SERVICE";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(199, 23);
            // 
            // date_end_service
            // 
            this.date_end_service.EditValue = null;
            this.date_end_service.Location = new System.Drawing.Point(228, 218);
            this.date_end_service.Name = "date_end_service";
            this.date_end_service.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_end_service.Properties.Appearance.Options.UseFont = true;
            this.date_end_service.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_end_service.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_end_service.Size = new System.Drawing.Size(1029, 30);
            this.date_end_service.StyleController = this.layoutControl1;
            this.date_end_service.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.date_end_service;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 204);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem7.Text = "DATE FIN DE SERVICE";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(199, 23);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.cmb_status;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 238);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1247, 34);
            this.layoutControlItem8.Text = "STATUS";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(199, 23);
            // 
            // cmb_status
            // 
            this.cmb_status.Location = new System.Drawing.Point(228, 252);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.Properties.Appearance.Options.UseFont = true;
            this.cmb_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_status.Properties.NullText = "";
            this.cmb_status.Properties.PopupSizeable = false;
            this.cmb_status.Size = new System.Drawing.Size(1029, 30);
            this.cmb_status.StyleController = this.layoutControl1;
            this.cmb_status.TabIndex = 11;
            // 
            // txt_observation
            // 
            this.txt_observation.Location = new System.Drawing.Point(228, 286);
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observation.Properties.Appearance.Options.UseFont = true;
            this.txt_observation.Size = new System.Drawing.Size(1029, 30);
            this.txt_observation.StyleController = this.layoutControl1;
            this.txt_observation.TabIndex = 12;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txt_observation;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 272);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1247, 76);
            this.layoutControlItem9.Text = "OBSERVATION";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(199, 23);
            // 
            // btn_add_update
            // 
            this.btn_add_update.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_update.Appearance.Options.UseFont = true;
            this.btn_add_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_add_update.Location = new System.Drawing.Point(176, 370);
            this.btn_add_update.Name = "btn_add_update";
            this.btn_add_update.Size = new System.Drawing.Size(168, 51);
            this.btn_add_update.TabIndex = 1;
            this.btn_add_update.Text = "Ajouter";
            this.btn_add_update.Click += new System.EventHandler(this.btn_add_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btn_cancel.Location = new System.Drawing.Point(360, 370);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(168, 51);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Anuller";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Add_Update_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 433);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add_update);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Update_Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Nouvelle véhicle";
            this.Load += new System.EventHandler(this.Add_Update_Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vehicle_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vehicle_number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_provider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_departement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_driver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start_service.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start_service.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end_service.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_end_service.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txt_vehicle_name;
        private DevExpress.XtraEditors.TextEdit txt_vehicle_number;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit cmb_provider;
        private DevExpress.XtraEditors.LookUpEdit cmb_departement;
        private DevExpress.XtraEditors.LookUpEdit cmb_driver;
        private DevExpress.XtraEditors.DateEdit date_start_service;
        private DevExpress.XtraEditors.DateEdit date_end_service;
        private DevExpress.XtraEditors.LookUpEdit cmb_status;
        private DevExpress.XtraEditors.TextEdit txt_observation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btn_add_update;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}
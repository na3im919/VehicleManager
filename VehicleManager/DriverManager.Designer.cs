namespace VehicleManager
{
    partial class DriverManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_drivers_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_drivers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_active_driver = new System.Windows.Forms.RadioButton();
            this.rad_deactivated_drivers = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Du Conducteurs";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 67);
            this.panel2.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(15, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(613, 31);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.groupBox1);
            this.panel13.Controls.Add(this.btn_delete);
            this.panel13.Controls.Add(this.btn_update);
            this.panel13.Controls.Add(this.btn_add);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 93);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1206, 83);
            this.panel13.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = global::VehicleManager.Properties.Resources.actions_deletecircled1;
            this.btn_delete.Location = new System.Drawing.Point(449, 6);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(189, 61);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(237, 6);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(189, 61);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Modéfier";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(15, 6);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(189, 61);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Ajouter";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_drivers_number);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 555);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1206, 52);
            this.panel3.TabIndex = 12;
            // 
            // lbl_drivers_number
            // 
            this.lbl_drivers_number.AutoSize = true;
            this.lbl_drivers_number.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drivers_number.Location = new System.Drawing.Point(273, 15);
            this.lbl_drivers_number.Name = "lbl_drivers_number";
            this.lbl_drivers_number.Size = new System.Drawing.Size(36, 26);
            this.lbl_drivers_number.TabIndex = 1;
            this.lbl_drivers_number.Text = "00";
            this.lbl_drivers_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Du Condecteurs :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_drivers
            // 
            this.dgv_drivers.AllowUserToAddRows = false;
            this.dgv_drivers.AllowUserToDeleteRows = false;
            this.dgv_drivers.AllowUserToOrderColumns = true;
            this.dgv_drivers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_drivers.Location = new System.Drawing.Point(0, 243);
            this.dgv_drivers.Name = "dgv_drivers";
            this.dgv_drivers.ReadOnly = true;
            this.dgv_drivers.RowHeadersWidth = 62;
            this.dgv_drivers.RowTemplate.Height = 28;
            this.dgv_drivers.Size = new System.Drawing.Size(1206, 312);
            this.dgv_drivers.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_deactivated_drivers);
            this.groupBox1.Controls.Add(this.rad_active_driver);
            this.groupBox1.Location = new System.Drawing.Point(656, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rad_active_driver
            // 
            this.rad_active_driver.AutoSize = true;
            this.rad_active_driver.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_active_driver.Location = new System.Drawing.Point(6, 12);
            this.rad_active_driver.Name = "rad_active_driver";
            this.rad_active_driver.Size = new System.Drawing.Size(212, 30);
            this.rad_active_driver.TabIndex = 0;
            this.rad_active_driver.TabStop = true;
            this.rad_active_driver.Text = "Conducteurs Active";
            this.rad_active_driver.UseVisualStyleBackColor = true;
            this.rad_active_driver.CheckedChanged += new System.EventHandler(this.rad_active_driver_CheckedChanged);
            // 
            // rad_deactivated_drivers
            // 
            this.rad_deactivated_drivers.AutoSize = true;
            this.rad_deactivated_drivers.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_deactivated_drivers.Location = new System.Drawing.Point(224, 12);
            this.rad_deactivated_drivers.Name = "rad_deactivated_drivers";
            this.rad_deactivated_drivers.Size = new System.Drawing.Size(240, 30);
            this.rad_deactivated_drivers.TabIndex = 1;
            this.rad_deactivated_drivers.TabStop = true;
            this.rad_deactivated_drivers.Text = "Conducteurs Supprimé";
            this.rad_deactivated_drivers.UseVisualStyleBackColor = true;
            this.rad_deactivated_drivers.CheckedChanged += new System.EventHandler(this.rad_deactivated_drivers_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VehicleManager.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(643, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DriverManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 607);
            this.Controls.Add(this.dgv_drivers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Name = "DriverManager";
            this.Text = "DriverManager";
            this.Load += new System.EventHandler(this.DriverManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel13;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_drivers_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_drivers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_deactivated_drivers;
        private System.Windows.Forms.RadioButton rad_active_driver;
    }
}
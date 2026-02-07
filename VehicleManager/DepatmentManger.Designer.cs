namespace VehicleManager
{
    partial class DepatmentManger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepatmentManger));
            this.dgv_departments = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_departments_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_deactivated_affectation = new System.Windows.Forms.RadioButton();
            this.rad_active_affectation = new System.Windows.Forms.RadioButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departments)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_departments
            // 
            this.dgv_departments.AllowUserToAddRows = false;
            this.dgv_departments.AllowUserToDeleteRows = false;
            this.dgv_departments.AllowUserToOrderColumns = true;
            this.dgv_departments.BackgroundColor = System.Drawing.Color.White;
            this.dgv_departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_departments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_departments.Location = new System.Drawing.Point(0, 243);
            this.dgv_departments.MultiSelect = false;
            this.dgv_departments.Name = "dgv_departments";
            this.dgv_departments.ReadOnly = true;
            this.dgv_departments.RowHeadersVisible = false;
            this.dgv_departments.RowHeadersWidth = 62;
            this.dgv_departments.RowTemplate.Height = 28;
            this.dgv_departments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_departments.Size = new System.Drawing.Size(1038, 155);
            this.dgv_departments.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_departments_number);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 52);
            this.panel3.TabIndex = 22;
            // 
            // lbl_departments_number
            // 
            this.lbl_departments_number.AutoSize = true;
            this.lbl_departments_number.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departments_number.Location = new System.Drawing.Point(349, 15);
            this.lbl_departments_number.Name = "lbl_departments_number";
            this.lbl_departments_number.Size = new System.Drawing.Size(36, 26);
            this.lbl_departments_number.TabIndex = 1;
            this.lbl_departments_number.Text = "00";
            this.lbl_departments_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre D\'Affectations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel2.Size = new System.Drawing.Size(1038, 67);
            this.panel2.TabIndex = 19;
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
            this.panel13.Size = new System.Drawing.Size(1038, 83);
            this.panel13.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_deactivated_affectation);
            this.groupBox1.Controls.Add(this.rad_active_affectation);
            this.groupBox1.Location = new System.Drawing.Point(656, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rad_deactivated_affectation
            // 
            this.rad_deactivated_affectation.AutoSize = true;
            this.rad_deactivated_affectation.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_deactivated_affectation.Location = new System.Drawing.Point(224, 12);
            this.rad_deactivated_affectation.Name = "rad_deactivated_affectation";
            this.rad_deactivated_affectation.Size = new System.Drawing.Size(238, 30);
            this.rad_deactivated_affectation.TabIndex = 1;
            this.rad_deactivated_affectation.TabStop = true;
            this.rad_deactivated_affectation.Text = "Affectations Supprimé";
            this.rad_deactivated_affectation.UseVisualStyleBackColor = true;
            this.rad_deactivated_affectation.CheckedChanged += new System.EventHandler(this.rad_deactivated_affectation_CheckedChanged);
            // 
            // rad_active_affectation
            // 
            this.rad_active_affectation.AutoSize = true;
            this.rad_active_affectation.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_active_affectation.Location = new System.Drawing.Point(6, 12);
            this.rad_active_affectation.Name = "rad_active_affectation";
            this.rad_active_affectation.Size = new System.Drawing.Size(210, 30);
            this.rad_active_affectation.TabIndex = 0;
            this.rad_active_affectation.TabStop = true;
            this.rad_active_affectation.Text = "Affectations Active";
            this.rad_active_affectation.UseVisualStyleBackColor = true;
            this.rad_active_affectation.CheckedChanged += new System.EventHandler(this.rad_active_affectation_CheckedChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 93);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion D\'Affectations";
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
            // DepatmentManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.dgv_departments);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Name = "DepatmentManger";
            this.Text = "DepatmentManger";
            this.Load += new System.EventHandler(this.DepatmentManger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_departments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_departments_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_deactivated_affectation;
        private System.Windows.Forms.RadioButton rad_active_affectation;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
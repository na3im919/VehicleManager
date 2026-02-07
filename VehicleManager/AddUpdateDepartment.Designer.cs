namespace VehicleManager
{
    partial class AddUpdateDepartment
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txt_department = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_update = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_department);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 111);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 111);
            this.Root.TextVisible = false;
            // 
            // txt_department
            // 
            this.txt_department.EditValue = "";
            this.txt_department.Location = new System.Drawing.Point(233, 18);
            this.txt_department.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_department.Name = "txt_department";
            this.txt_department.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Properties.Appearance.Options.UseFont = true;
            this.txt_department.Size = new System.Drawing.Size(549, 36);
            this.txt_department.StyleController = this.layoutControl1;
            this.txt_department.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txt_department;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(770, 81);
            this.layoutControlItem1.Text = "Nom D\'Affectation";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(197, 29);
            // 
            // btn_close
            // 
            this.btn_close.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.ImageOptions.SvgImage = global::VehicleManager.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(233, 207);
            this.btn_close.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(192, 63);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add_update
            // 
            this.btn_add_update.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_update.Appearance.Options.UseFont = true;
            this.btn_add_update.ImageOptions.SvgImage = global::VehicleManager.Properties.Resources.actions_add2;
            this.btn_add_update.Location = new System.Drawing.Point(18, 207);
            this.btn_add_update.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_add_update.Name = "btn_add_update";
            this.btn_add_update.Size = new System.Drawing.Size(192, 63);
            this.btn_add_update.TabIndex = 5;
            this.btn_add_update.Text = "Ajouter";
            this.btn_add_update.Click += new System.EventHandler(this.btn_add_update_Click);
            // 
            // AddUpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add_update);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUpdateDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txt_department;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_add_update;
    }
}
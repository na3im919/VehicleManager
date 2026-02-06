namespace VehicleManager
{
    partial class VehicleImages
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.flowImages = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsImageOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirLemplacementDimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmsImageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 87);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = global::VehicleManager.Properties.Resources.actions_deletecircled;
            this.btnDelete.Location = new System.Drawing.Point(387, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.SvgImage = global::VehicleManager.Properties.Resources.imagetoolssetimagescale;
            this.btnEdit.Location = new System.Drawing.Point(205, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = global::VehicleManager.Properties.Resources.insertimage;
            this.btnAdd.Location = new System.Drawing.Point(22, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flowImages
            // 
            this.flowImages.AutoScroll = true;
            this.flowImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowImages.Location = new System.Drawing.Point(0, 87);
            this.flowImages.Name = "flowImages";
            this.flowImages.Size = new System.Drawing.Size(1198, 366);
            this.flowImages.TabIndex = 11;
            // 
            // cmsImageOptions
            // 
            this.cmsImageOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsImageOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirLemplacementDimageToolStripMenuItem});
            this.cmsImageOptions.Name = "cmsImageOptions";
            this.cmsImageOptions.Size = new System.Drawing.Size(323, 36);
            // 
            // ouvrirLemplacementDimageToolStripMenuItem
            // 
            this.ouvrirLemplacementDimageToolStripMenuItem.Name = "ouvrirLemplacementDimageToolStripMenuItem";
            this.ouvrirLemplacementDimageToolStripMenuItem.Size = new System.Drawing.Size(322, 32);
            this.ouvrirLemplacementDimageToolStripMenuItem.Text = "Ouvrir l\'emplacement d\'image";
            this.ouvrirLemplacementDimageToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLemplacementDimageToolStripMenuItem_Click);
            // 
            // VehicleImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 453);
            this.Controls.Add(this.flowImages);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VehicleImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleImages";
            this.Load += new System.EventHandler(this.VehicleImages_Load);
            this.panel1.ResumeLayout(false);
            this.cmsImageOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.FlowLayoutPanel flowImages;
        private System.Windows.Forms.ContextMenuStrip cmsImageOptions;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLemplacementDimageToolStripMenuItem;
    }
}
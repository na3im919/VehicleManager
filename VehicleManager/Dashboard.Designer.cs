namespace VehicleManager
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_faulty_vehicles = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_veicles_in_repair = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_vehicles_on_service = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_all_vehicles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchField = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_import_xl = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_vehicles = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exporterVideFicherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1944, 238);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(1246, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(409, 238);
            this.panel7.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.lbl_faulty_vehicles);
            this.panel11.Controls.Add(this.pictureBox4);
            this.panel11.Location = new System.Drawing.Point(17, 13);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(375, 211);
            this.panel11.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "En Panne";
            // 
            // lbl_faulty_vehicles
            // 
            this.lbl_faulty_vehicles.AutoSize = true;
            this.lbl_faulty_vehicles.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faulty_vehicles.ForeColor = System.Drawing.Color.White;
            this.lbl_faulty_vehicles.Location = new System.Drawing.Point(80, 116);
            this.lbl_faulty_vehicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_faulty_vehicles.Name = "lbl_faulty_vehicles";
            this.lbl_faulty_vehicles.Size = new System.Drawing.Size(49, 57);
            this.lbl_faulty_vehicles.TabIndex = 4;
            this.lbl_faulty_vehicles.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(235, 90);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(837, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(409, 238);
            this.panel6.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(149)))), ((int)(((byte)(41)))));
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.lbl_veicles_in_repair);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Location = new System.Drawing.Point(17, 13);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(375, 211);
            this.panel10.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "En Réparation";
            // 
            // lbl_veicles_in_repair
            // 
            this.lbl_veicles_in_repair.AutoSize = true;
            this.lbl_veicles_in_repair.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veicles_in_repair.ForeColor = System.Drawing.Color.White;
            this.lbl_veicles_in_repair.Location = new System.Drawing.Point(105, 116);
            this.lbl_veicles_in_repair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_veicles_in_repair.Name = "lbl_veicles_in_repair";
            this.lbl_veicles_in_repair.Size = new System.Drawing.Size(49, 57);
            this.lbl_veicles_in_repair.TabIndex = 4;
            this.lbl_veicles_in_repair.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(253, 90);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(428, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(409, 238);
            this.panel5.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(165)))), ((int)(((byte)(119)))));
            this.panel9.Controls.Add(this.lbl_vehicles_on_service);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Location = new System.Drawing.Point(17, 13);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(375, 211);
            this.panel9.TabIndex = 1;
            // 
            // lbl_vehicles_on_service
            // 
            this.lbl_vehicles_on_service.AutoSize = true;
            this.lbl_vehicles_on_service.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicles_on_service.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicles_on_service.Location = new System.Drawing.Point(152, 116);
            this.lbl_vehicles_on_service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vehicles_on_service.Name = "lbl_vehicles_on_service";
            this.lbl_vehicles_on_service.Size = new System.Drawing.Size(49, 57);
            this.lbl_vehicles_on_service.TabIndex = 4;
            this.lbl_vehicles_on_service.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "En Service";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(253, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(19, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 238);
            this.panel4.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.panel8.Controls.Add(this.lbl_all_vehicles);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(17, 11);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(375, 211);
            this.panel8.TabIndex = 0;
            // 
            // lbl_all_vehicles
            // 
            this.lbl_all_vehicles.AutoSize = true;
            this.lbl_all_vehicles.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_all_vehicles.ForeColor = System.Drawing.Color.White;
            this.lbl_all_vehicles.Location = new System.Drawing.Point(58, 119);
            this.lbl_all_vehicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_all_vehicles.Name = "lbl_all_vehicles";
            this.lbl_all_vehicles.Size = new System.Drawing.Size(49, 57);
            this.lbl_all_vehicles.TabIndex = 2;
            this.lbl_all_vehicles.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tous Les Véhicules";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 238);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.cmbSearchField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1944, 67);
            this.panel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(375, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(613, 31);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSearchField
            // 
            this.cmbSearchField.BackColor = System.Drawing.Color.White;
            this.cmbSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchField.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchField.FormattingEnabled = true;
            this.cmbSearchField.Items.AddRange(new object[] {
            "Véhicule",
            "Préstataire",
            "Service Fait (Conducteur)",
            "Immatriculation",
            "Affectation",
            "Status",
            "DATE MISE EN SERVICE",
            "DATE FIN DE SERVICE"});
            this.cmbSearchField.Location = new System.Drawing.Point(15, 19);
            this.cmbSearchField.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchField.Name = "cmbSearchField";
            this.cmbSearchField.Size = new System.Drawing.Size(332, 34);
            this.cmbSearchField.TabIndex = 0;
            this.cmbSearchField.SelectedIndexChanged += new System.EventHandler(this.cmbSearchField_SelectedIndexChanged);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.btn_import_xl);
            this.panel13.Controls.Add(this.btn_delete);
            this.panel13.Controls.Add(this.btn_update);
            this.panel13.Controls.Add(this.btn_add);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 238);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1944, 99);
            this.panel13.TabIndex = 2;
            // 
            // btn_import_xl
            // 
            this.btn_import_xl.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import_xl.Appearance.Options.UseFont = true;
            this.btn_import_xl.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_import_xl.ImageOptions.SvgImage")));
            this.btn_import_xl.Location = new System.Drawing.Point(683, 19);
            this.btn_import_xl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_import_xl.Name = "btn_import_xl";
            this.btn_import_xl.Size = new System.Drawing.Size(189, 61);
            this.btn_import_xl.TabIndex = 3;
            this.btn_import_xl.Text = "Importer";
            this.btn_import_xl.Click += new System.EventHandler(this.btn_import_xl_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(469, 19);
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
            this.btn_update.Location = new System.Drawing.Point(257, 19);
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
            this.btn_add.Location = new System.Drawing.Point(35, 19);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(189, 61);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Ajouter";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_vehicles
            // 
            this.dgv_vehicles.AllowUserToAddRows = false;
            this.dgv_vehicles.AllowUserToDeleteRows = false;
            this.dgv_vehicles.AllowUserToOrderColumns = true;
            this.dgv_vehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehicles.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vehicles.Location = new System.Drawing.Point(0, 404);
            this.dgv_vehicles.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_vehicles.MultiSelect = false;
            this.dgv_vehicles.Name = "dgv_vehicles";
            this.dgv_vehicles.ReadOnly = true;
            this.dgv_vehicles.RowHeadersVisible = false;
            this.dgv_vehicles.RowHeadersWidth = 51;
            this.dgv_vehicles.RowTemplate.Height = 24;
            this.dgv_vehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vehicles.Size = new System.Drawing.Size(1944, 477);
            this.dgv_vehicles.TabIndex = 3;
            this.dgv_vehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehicles_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterVideFicherToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(289, 36);
            // 
            // exporterVideFicherToolStripMenuItem
            // 
            this.exporterVideFicherToolStripMenuItem.Name = "exporterVideFicherToolStripMenuItem";
            this.exporterVideFicherToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.exporterVideFicherToolStripMenuItem.Text = "Exporter Fichier Excel Vide";
            this.exporterVideFicherToolStripMenuItem.Click += new System.EventHandler(this.exporterVideFicherToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 881);
            this.Controls.Add(this.dgv_vehicles);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchField;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_vehicles_on_service;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_veicles_in_repair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_faulty_vehicles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel13;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_import_xl;
        private System.Windows.Forms.DataGridView dgv_vehicles;
        public System.Windows.Forms.Label lbl_all_vehicles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exporterVideFicherToolStripMenuItem;
    }
}
namespace CarRentalManagementSystem.Vehicles
{
    partial class FrmListVehicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVehiclesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbVehicles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showVehicleBookingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVehicleMaintenanceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbTemp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPreviousPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnCurrentPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.cbPageSizes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiclesList)).BeginInit();
            this.cbVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiclesList
            // 
            this.dgvVehiclesList.AllowUserToAddRows = false;
            this.dgvVehiclesList.AllowUserToDeleteRows = false;
            this.dgvVehiclesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvVehiclesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiclesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVehiclesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvVehiclesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiclesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehiclesList.ColumnHeadersHeight = 45;
            this.dgvVehiclesList.ContextMenuStrip = this.cbVehicles;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiclesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehiclesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvVehiclesList.Location = new System.Drawing.Point(32, 246);
            this.dgvVehiclesList.MultiSelect = false;
            this.dgvVehiclesList.Name = "dgvVehiclesList";
            this.dgvVehiclesList.ReadOnly = true;
            this.dgvVehiclesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiclesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVehiclesList.RowHeadersVisible = false;
            this.dgvVehiclesList.RowHeadersWidth = 51;
            this.dgvVehiclesList.RowTemplate.Height = 50;
            this.dgvVehiclesList.Size = new System.Drawing.Size(1185, 437);
            this.dgvVehiclesList.TabIndex = 24;
            this.dgvVehiclesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.dgvVehiclesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvVehiclesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVehiclesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVehiclesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVehiclesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVehiclesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehiclesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvVehiclesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.dgvVehiclesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehiclesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvVehiclesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVehiclesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVehiclesList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvVehiclesList.ThemeStyle.ReadOnly = true;
            this.dgvVehiclesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.dgvVehiclesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvVehiclesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvVehiclesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvVehiclesList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvVehiclesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.dgvVehiclesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvVehiclesList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVehiclesList_CellContentDoubleClick);
            this.dgvVehiclesList.SelectionChanged += new System.EventHandler(this.DgvVehiclesList_SelectionChanged);
            // 
            // cbVehicles
            // 
            this.cbVehicles.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbVehicles.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cbVehicles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewVehicleToolStripMenuItem,
            this.editVehicleInformationToolStripMenuItem,
            this.showVehicleInformationToolStripMenuItem,
            this.deleteVehicleToolStripMenuItem,
            this.maintainVehicleToolStripMenuItem,
            this.toolStripSeparator1,
            this.showVehicleBookingHistoryToolStripMenuItem,
            this.showVehicleMaintenanceHistoryToolStripMenuItem});
            this.cbVehicles.Name = "cbUsers";
            this.cbVehicles.Size = new System.Drawing.Size(346, 304);
            this.cbVehicles.Opening += new System.ComponentModel.CancelEventHandler(this.CbVehicles_Opening);
            // 
            // addNewVehicleToolStripMenuItem
            // 
            this.addNewVehicleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.addNewVehicleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewVehicleToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources._3d_car__1_;
            this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
            this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(345, 42);
            this.addNewVehicleToolStripMenuItem.Text = "Add New Vehicle";
            this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.AddNewVehicleToolStripMenuItem_Click);
            // 
            // editVehicleInformationToolStripMenuItem
            // 
            this.editVehicleInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.editVehicleInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editVehicleInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.edit;
            this.editVehicleInformationToolStripMenuItem.Name = "editVehicleInformationToolStripMenuItem";
            this.editVehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(345, 42);
            this.editVehicleInformationToolStripMenuItem.Text = "Edit Vehicle Information";
            this.editVehicleInformationToolStripMenuItem.Click += new System.EventHandler(this.EditVehiclesInformationToolStripMenuItem_Click);
            // 
            // showVehicleInformationToolStripMenuItem
            // 
            this.showVehicleInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showVehicleInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showVehicleInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.eye;
            this.showVehicleInformationToolStripMenuItem.Name = "showVehicleInformationToolStripMenuItem";
            this.showVehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(345, 42);
            this.showVehicleInformationToolStripMenuItem.Text = "Show Vehicle Information";
            this.showVehicleInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowVehiclesInformationToolStripMenuItem_Click);
            // 
            // deleteVehicleToolStripMenuItem
            // 
            this.deleteVehicleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.deleteVehicleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteVehicleToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.trash_bin;
            this.deleteVehicleToolStripMenuItem.Name = "deleteVehicleToolStripMenuItem";
            this.deleteVehicleToolStripMenuItem.Size = new System.Drawing.Size(345, 42);
            this.deleteVehicleToolStripMenuItem.Text = "Delete Vehicle";
            this.deleteVehicleToolStripMenuItem.Click += new System.EventHandler(this.DeleteVehiclesToolStripMenuItem_Click);
            // 
            // maintainVehicleToolStripMenuItem
            // 
            this.maintainVehicleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.maintainVehicleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.maintainVehicleToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.gear;
            this.maintainVehicleToolStripMenuItem.Name = "maintainVehicleToolStripMenuItem";
            this.maintainVehicleToolStripMenuItem.Size = new System.Drawing.Size(345, 42);
            this.maintainVehicleToolStripMenuItem.Text = "Maintain Vehicle";
            this.maintainVehicleToolStripMenuItem.Click += new System.EventHandler(this.MaintainVehicleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(342, 6);
            // 
            // showVehicleBookingHistoryToolStripMenuItem
            // 
            this.showVehicleBookingHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showVehicleBookingHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showVehicleBookingHistoryToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.rental_car;
            this.showVehicleBookingHistoryToolStripMenuItem.Name = "showVehicleBookingHistoryToolStripMenuItem";
            this.showVehicleBookingHistoryToolStripMenuItem.Size = new System.Drawing.Size(345, 42);
            this.showVehicleBookingHistoryToolStripMenuItem.Text = "Show Vehicle Booking History";
            this.showVehicleBookingHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowVehicleBookingHistoryToolStripMenuItem_Click);
            // 
            // showVehicleMaintenanceHistoryToolStripMenuItem
            // 
            this.showVehicleMaintenanceHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showVehicleMaintenanceHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showVehicleMaintenanceHistoryToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.gear;
            this.showVehicleMaintenanceHistoryToolStripMenuItem.Name = "showVehicleMaintenanceHistoryToolStripMenuItem";
            this.showVehicleMaintenanceHistoryToolStripMenuItem.Size = new System.Drawing.Size(345, 42);
            this.showVehicleMaintenanceHistoryToolStripMenuItem.Text = "Show Vehicle Maintenance History";
            this.showVehicleMaintenanceHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowVehicleMaintenanceHistoryToolStripMenuItem_Click);
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByOptions.BorderRadius = 22;
            this.cbFilterByOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbFilterByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByOptions.ItemHeight = 35;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "None",
            "Vehicle ID",
            "Vehicle Name",
            "Make",
            "Model",
            "Sub Model",
            "Drive Type",
            "Fuel Type",
            "Engine",
            "Doors",
            "Rental Price Per Day",
            "Status"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(119, 189);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(236, 41);
            this.cbFilterByOptions.TabIndex = 23;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter by :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(34, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1188, 10);
            this.guna2Separator1.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.lblTitle.Location = new System.Drawing.Point(126, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 31);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Manage Vehicles";
            // 
            // cbTemp
            // 
            this.cbTemp.BackColor = System.Drawing.Color.Transparent;
            this.cbTemp.BorderRadius = 22;
            this.cbTemp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTemp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTemp.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbTemp.ForeColor = System.Drawing.Color.Black;
            this.cbTemp.ItemHeight = 35;
            this.cbTemp.Items.AddRange(new object[] {
            "User ID",
            "Full Name",
            "Gender",
            "UserName",
            "Country",
            "Is Active"});
            this.cbTemp.Location = new System.Drawing.Point(374, 188);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(192, 41);
            this.cbTemp.TabIndex = 26;
            this.cbTemp.Visible = false;
            this.cbTemp.SelectedIndexChanged += new System.EventHandler(this.CbTemp_SelectedIndexChanged);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnPreviousPage.BorderRadius = 8;
            this.btnPreviousPage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnPreviousPage.BorderThickness = 3;
            this.btnPreviousPage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnPreviousPage.CheckedState.FillColor = System.Drawing.Color.Tan;
            this.btnPreviousPage.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnPreviousPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPreviousPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPreviousPage.DisabledState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnPreviousPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPreviousPage.FillColor = System.Drawing.Color.White;
            this.btnPreviousPage.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnPreviousPage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnPreviousPage.HoverState.FillColor = System.Drawing.Color.Tan;
            this.btnPreviousPage.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnPreviousPage.Location = new System.Drawing.Point(516, 695);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(78, 45);
            this.btnPreviousPage.TabIndex = 27;
            this.btnPreviousPage.Text = "<<";
            this.btnPreviousPage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnPreviousPage.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // btnCurrentPage
            // 
            this.btnCurrentPage.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrentPage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnCurrentPage.BorderRadius = 8;
            this.btnCurrentPage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCurrentPage.BorderThickness = 3;
            this.btnCurrentPage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnCurrentPage.CheckedState.FillColor = System.Drawing.Color.Tan;
            this.btnCurrentPage.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnCurrentPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentPage.DisabledState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCurrentPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCurrentPage.FillColor = System.Drawing.Color.White;
            this.btnCurrentPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCurrentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnCurrentPage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnCurrentPage.HoverState.FillColor = System.Drawing.Color.Tan;
            this.btnCurrentPage.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnCurrentPage.Location = new System.Drawing.Point(594, 695);
            this.btnCurrentPage.Name = "btnCurrentPage";
            this.btnCurrentPage.Size = new System.Drawing.Size(78, 45);
            this.btnCurrentPage.TabIndex = 28;
            this.btnCurrentPage.Text = "1";
            this.btnCurrentPage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCurrentPage.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnNextPage.BorderRadius = 8;
            this.btnNextPage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnNextPage.BorderThickness = 3;
            this.btnNextPage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnNextPage.CheckedState.FillColor = System.Drawing.Color.Tan;
            this.btnNextPage.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnNextPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnNextPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextPage.FillColor = System.Drawing.Color.White;
            this.btnNextPage.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnNextPage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnNextPage.HoverState.FillColor = System.Drawing.Color.Tan;
            this.btnNextPage.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnNextPage.Location = new System.Drawing.Point(672, 695);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(78, 45);
            this.btnNextPage.TabIndex = 29;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnNextPage.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // cbPageSizes
            // 
            this.cbPageSizes.BackColor = System.Drawing.Color.Transparent;
            this.cbPageSizes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.cbPageSizes.BorderRadius = 22;
            this.cbPageSizes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPageSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageSizes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.cbPageSizes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.cbPageSizes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.cbPageSizes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbPageSizes.ForeColor = System.Drawing.Color.White;
            this.cbPageSizes.ItemHeight = 35;
            this.cbPageSizes.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "150",
            "500",
            "1000"});
            this.cbPageSizes.Location = new System.Drawing.Point(1114, 690);
            this.cbPageSizes.Name = "cbPageSizes";
            this.cbPageSizes.Size = new System.Drawing.Size(103, 41);
            this.cbPageSizes.StartIndex = 0;
            this.cbPageSizes.TabIndex = 31;
            this.cbPageSizes.SelectedIndexChanged += new System.EventHandler(this.CbPageSizes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1017, 700);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Page size :";
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.BorderRadius = 22;
            this.btnAddNewVehicle.CustomizableEdges.TopRight = false;
            this.btnAddNewVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewVehicle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.Image = global::CarRentalManagementSystem.Properties.Resources.plus;
            this.btnAddNewVehicle.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewVehicle.Location = new System.Drawing.Point(1012, 178);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(205, 51);
            this.btnAddNewVehicle.TabIndex = 25;
            this.btnAddNewVehicle.Text = "Add New Vehicle";
            this.btnAddNewVehicle.Click += new System.EventHandler(this.BtnAddNewVehicle_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 22;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.IconRight = global::CarRentalManagementSystem.Properties.Resources.search;
            this.txtFilterValue.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtFilterValue.Location = new System.Drawing.Point(374, 187);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 43);
            this.txtFilterValue.TabIndex = 22;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.TxtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(85, 85);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(85, 85);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources._3d_car;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(85, 85);
            this.guna2ImageButton1.Location = new System.Drawing.Point(32, 16);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(85, 85);
            this.guna2ImageButton1.Size = new System.Drawing.Size(91, 80);
            this.guna2ImageButton1.TabIndex = 19;
            // 
            // FrmListVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 759);
            this.Controls.Add(this.cbPageSizes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnCurrentPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.dgvVehiclesList);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.btnAddNewVehicle);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListVehicles";
            this.Load += new System.EventHandler(this.FrmListVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiclesList)).EndInit();
            this.cbVehicles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvVehiclesList;
        private System.Windows.Forms.ContextMenuStrip cbVehicles;
        private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehicleInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVehicleInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbTemp;
        private Guna.UI2.WinForms.Guna2Button btnAddNewVehicle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button btnPreviousPage;
        private Guna.UI2.WinForms.Guna2Button btnCurrentPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private Guna.UI2.WinForms.Guna2ComboBox cbPageSizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem maintainVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showVehicleBookingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVehicleMaintenanceHistoryToolStripMenuItem;
    }
}
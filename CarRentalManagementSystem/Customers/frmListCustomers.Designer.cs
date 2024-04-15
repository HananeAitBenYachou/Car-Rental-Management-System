namespace CarRentalManagementSystem.Customers
{
    partial class FrmListCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListCustomers));
            this.dgvCustomersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbCustomers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showCustomerBookingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomerTransactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbTemp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            this.cbCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvCustomersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCustomersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvCustomersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomersList.ColumnHeadersHeight = 45;
            this.dgvCustomersList.ContextMenuStrip = this.cbCustomers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvCustomersList.Location = new System.Drawing.Point(32, 279);
            this.dgvCustomersList.MultiSelect = false;
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomersList.RowHeadersVisible = false;
            this.dgvCustomersList.RowHeadersWidth = 51;
            this.dgvCustomersList.RowTemplate.Height = 50;
            this.dgvCustomersList.Size = new System.Drawing.Size(1185, 437);
            this.dgvCustomersList.TabIndex = 15;
            this.dgvCustomersList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvCustomersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.dgvCustomersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCustomersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomersList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvCustomersList.ThemeStyle.ReadOnly = true;
            this.dgvCustomersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.dgvCustomersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvCustomersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCustomersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvCustomersList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvCustomersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.dgvCustomersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvCustomersList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomersList_CellDoubleContentClick);
            this.dgvCustomersList.SelectionChanged += new System.EventHandler(this.DgvCustomersList_SelectionChanged);
            // 
            // cbCustomers
            // 
            this.cbCustomers.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbCustomers.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cbCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.editCustomerInformationToolStripMenuItem,
            this.showCustomerInformationToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem,
            this.toolStripSeparator1,
            this.showCustomerBookingHistoryToolStripMenuItem,
            this.showCustomerTransactionHistoryToolStripMenuItem});
            this.cbCustomers.Name = "cbUsers";
            this.cbCustomers.Size = new System.Drawing.Size(363, 254);
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.addNewCustomerToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.addNewCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewCustomerToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.folder1;
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddNewCustomerToolStripMenuItem_Click);
            // 
            // editCustomerInformationToolStripMenuItem
            // 
            this.editCustomerInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.editCustomerInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.editCustomerInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editCustomerInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.edit;
            this.editCustomerInformationToolStripMenuItem.Name = "editCustomerInformationToolStripMenuItem";
            this.editCustomerInformationToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.editCustomerInformationToolStripMenuItem.Text = "Edit Customer Information";
            this.editCustomerInformationToolStripMenuItem.Click += new System.EventHandler(this.EditCustomerInformationToolStripMenuItem_Click);
            // 
            // showCustomerInformationToolStripMenuItem
            // 
            this.showCustomerInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showCustomerInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showCustomerInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showCustomerInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.eye;
            this.showCustomerInformationToolStripMenuItem.Name = "showCustomerInformationToolStripMenuItem";
            this.showCustomerInformationToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.showCustomerInformationToolStripMenuItem.Text = "Show Customer Information";
            this.showCustomerInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowCustomerInformationToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.deleteCustomerToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.deleteCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteCustomerToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.trash_bin;
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.DeleteCustomerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(359, 6);
            // 
            // showCustomerBookingHistoryToolStripMenuItem
            // 
            this.showCustomerBookingHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showCustomerBookingHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showCustomerBookingHistoryToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.rental_car;
            this.showCustomerBookingHistoryToolStripMenuItem.Name = "showCustomerBookingHistoryToolStripMenuItem";
            this.showCustomerBookingHistoryToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.showCustomerBookingHistoryToolStripMenuItem.Text = "Show Customer Booking History";
            this.showCustomerBookingHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowCustomerBookingHistoryToolStripMenuItem_Click);
            // 
            // showCustomerTransactionHistoryToolStripMenuItem
            // 
            this.showCustomerTransactionHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showCustomerTransactionHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showCustomerTransactionHistoryToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.transaction1;
            this.showCustomerTransactionHistoryToolStripMenuItem.Name = "showCustomerTransactionHistoryToolStripMenuItem";
            this.showCustomerTransactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(362, 36);
            this.showCustomerTransactionHistoryToolStripMenuItem.Text = "Show Customer Transaction History";
            this.showCustomerTransactionHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowCustomerTransactionHistoryToolStripMenuItem_Click);
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
            "Customer ID",
            "Full Name",
            "National No",
            "License Number",
            "Gender",
            "Country"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(119, 212);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByOptions.TabIndex = 14;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter by :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(34, 85);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1188, 10);
            this.guna2Separator1.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.lblTitle.Location = new System.Drawing.Point(96, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Manage Customers";
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
            this.cbTemp.Location = new System.Drawing.Point(341, 211);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(192, 41);
            this.cbTemp.TabIndex = 17;
            this.cbTemp.Visible = false;
            this.cbTemp.SelectedIndexChanged += new System.EventHandler(this.CbTemp_SelectedIndexChanged);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BorderRadius = 22;
            this.btnAddNewCustomer.CustomizableEdges.TopRight = false;
            this.btnAddNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Image = global::CarRentalManagementSystem.Properties.Resources.plus;
            this.btnAddNewCustomer.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewCustomer.Location = new System.Drawing.Point(1012, 201);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(205, 51);
            this.btnAddNewCustomer.TabIndex = 16;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomer_Click);
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
            this.txtFilterValue.Location = new System.Drawing.Point(341, 210);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 43);
            this.txtFilterValue.TabIndex = 13;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.TxtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(28, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 10;
            // 
            // FrmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 759);
            this.Controls.Add(this.dgvCustomersList);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListCustomers";
            this.Load += new System.EventHandler(this.FrmListCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            this.cbCustomers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomersList;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbTemp;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.ContextMenuStrip cbCustomers;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerBookingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomerTransactionHistoryToolStripMenuItem;
    }
}
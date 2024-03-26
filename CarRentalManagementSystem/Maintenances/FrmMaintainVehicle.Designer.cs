namespace CarRentalManagementSystem.Maintenances
{
    partial class FrmMaintainVehicle
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMaintainVehicle = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpVehicleInfo = new System.Windows.Forms.TabPage();
            this.tpMaintenanceInfo = new System.Windows.Forms.TabPage();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMaintenanceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMaintenanceID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ucVehicleCardWithFilter1 = new CarRentalManagementSystem.Vehicles.UserControls.UcVehicleCardWithFilter();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcMaintainVehicle.SuspendLayout();
            this.tpVehicleInfo.SuspendLayout();
            this.tpMaintenanceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2ImageButton1);
            this.guna2GradientPanel1.Controls.Add(this.lblTitle);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(978, 88);
            this.guna2GradientPanel1.TabIndex = 206;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Maintain Vehicle";
            // 
            // tcMaintainVehicle
            // 
            this.tcMaintainVehicle.Controls.Add(this.tpVehicleInfo);
            this.tcMaintainVehicle.Controls.Add(this.tpMaintenanceInfo);
            this.tcMaintainVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMaintainVehicle.ItemSize = new System.Drawing.Size(180, 50);
            this.tcMaintainVehicle.Location = new System.Drawing.Point(0, 88);
            this.tcMaintainVehicle.Name = "tcMaintainVehicle";
            this.tcMaintainVehicle.SelectedIndex = 0;
            this.tcMaintainVehicle.Size = new System.Drawing.Size(978, 794);
            this.tcMaintainVehicle.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintainVehicle.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintainVehicle.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintainVehicle.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMaintainVehicle.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintainVehicle.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintainVehicle.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintainVehicle.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintainVehicle.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcMaintainVehicle.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintainVehicle.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintainVehicle.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintainVehicle.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintainVehicle.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMaintainVehicle.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.tcMaintainVehicle.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcMaintainVehicle.TabIndex = 207;
            this.tcMaintainVehicle.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintainVehicle.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpVehicleInfo
            // 
            this.tpVehicleInfo.Controls.Add(this.ucVehicleCardWithFilter1);
            this.tpVehicleInfo.Controls.Add(this.btnClose);
            this.tpVehicleInfo.Controls.Add(this.btnNext);
            this.tpVehicleInfo.Location = new System.Drawing.Point(4, 54);
            this.tpVehicleInfo.Name = "tpVehicleInfo";
            this.tpVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicleInfo.Size = new System.Drawing.Size(970, 736);
            this.tpVehicleInfo.TabIndex = 0;
            this.tpVehicleInfo.Text = "Vehicle Info";
            this.tpVehicleInfo.UseVisualStyleBackColor = true;
            // 
            // tpMaintenanceInfo
            // 
            this.tpMaintenanceInfo.Controls.Add(this.btnSave);
            this.tpMaintenanceInfo.Controls.Add(this.txtDescription);
            this.tpMaintenanceInfo.Controls.Add(this.label11);
            this.tpMaintenanceInfo.Controls.Add(this.txtCost);
            this.tpMaintenanceInfo.Controls.Add(this.label9);
            this.tpMaintenanceInfo.Controls.Add(this.label5);
            this.tpMaintenanceInfo.Controls.Add(this.dtpMaintenanceDate);
            this.tpMaintenanceInfo.Controls.Add(this.txtMaintenanceID);
            this.tpMaintenanceInfo.Controls.Add(this.label3);
            this.tpMaintenanceInfo.Controls.Add(this.txtVehicleID);
            this.tpMaintenanceInfo.Controls.Add(this.label1);
            this.tpMaintenanceInfo.Location = new System.Drawing.Point(4, 54);
            this.tpMaintenanceInfo.Name = "tpMaintenanceInfo";
            this.tpMaintenanceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaintenanceInfo.Size = new System.Drawing.Size(970, 736);
            this.tpMaintenanceInfo.TabIndex = 2;
            this.tpMaintenanceInfo.Text = "Maintenance Info";
            this.tpMaintenanceInfo.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 22;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtDescription.Location = new System.Drawing.Point(210, 210);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(712, 99);
            this.txtDescription.TabIndex = 261;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label11.Location = new System.Drawing.Point(31, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 260;
            this.label11.Text = "Description :";
            // 
            // txtCost
            // 
            this.txtCost.BorderRadius = 22;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.DefaultText = "";
            this.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCost.ForeColor = System.Drawing.Color.Black;
            this.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtCost.Location = new System.Drawing.Point(693, 132);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PlaceholderText = "";
            this.txtCost.SelectedText = "";
            this.txtCost.Size = new System.Drawing.Size(229, 43);
            this.txtCost.TabIndex = 257;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCost_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label9.Location = new System.Drawing.Point(546, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 256;
            this.label9.Text = "Cost  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label5.Location = new System.Drawing.Point(31, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 214;
            this.label5.Text = "Maintenance Date :";
            // 
            // dtpMaintenanceDate
            // 
            this.dtpMaintenanceDate.BorderRadius = 22;
            this.dtpMaintenanceDate.Checked = true;
            this.dtpMaintenanceDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dtpMaintenanceDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpMaintenanceDate.Location = new System.Drawing.Point(210, 132);
            this.dtpMaintenanceDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMaintenanceDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            this.dtpMaintenanceDate.Size = new System.Drawing.Size(229, 43);
            this.dtpMaintenanceDate.TabIndex = 213;
            this.dtpMaintenanceDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // txtMaintenanceID
            // 
            this.txtMaintenanceID.BorderRadius = 22;
            this.txtMaintenanceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaintenanceID.DefaultText = "N/A";
            this.txtMaintenanceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaintenanceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaintenanceID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaintenanceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaintenanceID.Enabled = false;
            this.txtMaintenanceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaintenanceID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenanceID.ForeColor = System.Drawing.Color.Red;
            this.txtMaintenanceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaintenanceID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtMaintenanceID.Location = new System.Drawing.Point(210, 54);
            this.txtMaintenanceID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaintenanceID.Name = "txtMaintenanceID";
            this.txtMaintenanceID.PasswordChar = '\0';
            this.txtMaintenanceID.PlaceholderText = "";
            this.txtMaintenanceID.ReadOnly = true;
            this.txtMaintenanceID.SelectedText = "";
            this.txtMaintenanceID.Size = new System.Drawing.Size(229, 43);
            this.txtMaintenanceID.TabIndex = 210;
            this.txtMaintenanceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 209;
            this.label3.Text = "Maintenance ID :";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.BorderRadius = 22;
            this.txtVehicleID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleID.DefaultText = "N/A";
            this.txtVehicleID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtVehicleID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleID.Enabled = false;
            this.txtVehicleID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVehicleID.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtVehicleID.Location = new System.Drawing.Point(693, 54);
            this.txtVehicleID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.PasswordChar = '\0';
            this.txtVehicleID.PlaceholderText = "";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.SelectedText = "";
            this.txtVehicleID.Size = new System.Drawing.Size(229, 43);
            this.txtVehicleID.TabIndex = 206;
            this.txtVehicleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(546, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 205;
            this.label1.Text = "Vehicle ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 22;
            this.btnClose.CustomizableEdges.TopLeft = false;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::CarRentalManagementSystem.Properties.Resources.cross_mark_on_a_black_circle_background;
            this.btnClose.Location = new System.Drawing.Point(6, 669);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 53);
            this.btnClose.TabIndex = 233;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 22;
            this.btnNext.CustomizableEdges.TopRight = false;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnNext.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::CarRentalManagementSystem.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(796, 669);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(171, 53);
            this.btnNext.TabIndex = 232;
            this.btnNext.Text = "Next";
            this.btnNext.EnabledChanged += new System.EventHandler(this.BtnNext_EnabledChanged);
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 22;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CarRentalManagementSystem.Properties.Resources.folder;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(744, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 66);
            this.btnSave.TabIndex = 262;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.car_repair;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(28, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // ucVehicleCardWithFilter1
            // 
            this.ucVehicleCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucVehicleCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucVehicleCardWithFilter1.FilterEnabled = true;
            this.ucVehicleCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucVehicleCardWithFilter1.Name = "ucVehicleCardWithFilter1";
            this.ucVehicleCardWithFilter1.Size = new System.Drawing.Size(964, 654);
            this.ucVehicleCardWithFilter1.TabIndex = 234;
            // 
            // FrmMaintainVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 882);
            this.Controls.Add(this.tcMaintainVehicle);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaintainVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMaintainVehicle";
            this.Load += new System.EventHandler(this.FrmMaintainVehicle_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcMaintainVehicle.ResumeLayout(false);
            this.tpVehicleInfo.ResumeLayout(false);
            this.tpMaintenanceInfo.ResumeLayout(false);
            this.tpMaintenanceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcMaintainVehicle;
        private System.Windows.Forms.TabPage tpVehicleInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage tpMaintenanceInfo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMaintenanceDate;
        private Guna.UI2.WinForms.Guna2TextBox txtMaintenanceID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Vehicles.UserControls.UcVehicleCardWithFilter ucVehicleCardWithFilter1;
    }
}
namespace CarRentalManagementSystem.Bookings
{
    partial class FrmAddRentalBooking
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcRentalBooking = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnToVehicleInfo = new Guna.UI2.WinForms.Guna2Button();
            this.ucCustomerCardWithFilter1 = new CarRentalManagementSystem.Customers.UserControls.UcCustomerCardWithFilter();
            this.tpVehicleInfo = new System.Windows.Forms.TabPage();
            this.btnToBookingInfo = new Guna.UI2.WinForms.Guna2Button();
            this.ucVehicleCardWithFilter1 = new CarRentalManagementSystem.Vehicles.UserControls.UcVehicleCardWithFilter();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtInitialCheckNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPickUpLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDropOffLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRentalPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInitialTotalDueAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudInitialRentalDays = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.tcRentalBooking.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tpVehicleInfo.SuspendLayout();
            this.tpBookingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialRentalDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1061, 88);
            this.guna2GradientPanel1.TabIndex = 203;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.rental;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(28, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Vehicle Booking";
            // 
            // tcRentalBooking
            // 
            this.tcRentalBooking.Controls.Add(this.tpCustomerInfo);
            this.tcRentalBooking.Controls.Add(this.tpVehicleInfo);
            this.tcRentalBooking.Controls.Add(this.tpBookingInfo);
            this.tcRentalBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcRentalBooking.ItemSize = new System.Drawing.Size(180, 50);
            this.tcRentalBooking.Location = new System.Drawing.Point(0, 88);
            this.tcRentalBooking.Name = "tcRentalBooking";
            this.tcRentalBooking.SelectedIndex = 0;
            this.tcRentalBooking.Size = new System.Drawing.Size(1061, 884);
            this.tcRentalBooking.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcRentalBooking.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcRentalBooking.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcRentalBooking.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcRentalBooking.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcRentalBooking.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcRentalBooking.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcRentalBooking.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcRentalBooking.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcRentalBooking.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcRentalBooking.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcRentalBooking.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcRentalBooking.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcRentalBooking.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcRentalBooking.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.tcRentalBooking.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcRentalBooking.TabIndex = 204;
            this.tcRentalBooking.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcRentalBooking.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.Controls.Add(this.btnClose);
            this.tpCustomerInfo.Controls.Add(this.btnToVehicleInfo);
            this.tpCustomerInfo.Controls.Add(this.ucCustomerCardWithFilter1);
            this.tpCustomerInfo.Location = new System.Drawing.Point(4, 54);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomerInfo.Size = new System.Drawing.Size(1053, 826);
            this.tpCustomerInfo.TabIndex = 0;
            this.tpCustomerInfo.Text = "Customer Info";
            this.tpCustomerInfo.UseVisualStyleBackColor = true;
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
            this.btnClose.Location = new System.Drawing.Point(3, 758);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 53);
            this.btnClose.TabIndex = 233;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnToVehicleInfo
            // 
            this.btnToVehicleInfo.BorderRadius = 22;
            this.btnToVehicleInfo.CustomizableEdges.TopRight = false;
            this.btnToVehicleInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToVehicleInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToVehicleInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToVehicleInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToVehicleInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnToVehicleInfo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToVehicleInfo.ForeColor = System.Drawing.Color.White;
            this.btnToVehicleInfo.Image = global::CarRentalManagementSystem.Properties.Resources.next;
            this.btnToVehicleInfo.Location = new System.Drawing.Point(879, 758);
            this.btnToVehicleInfo.Name = "btnToVehicleInfo";
            this.btnToVehicleInfo.Size = new System.Drawing.Size(171, 53);
            this.btnToVehicleInfo.TabIndex = 232;
            this.btnToVehicleInfo.Text = "Next";
            this.btnToVehicleInfo.EnabledChanged += new System.EventHandler(this.BtnToVehicleInfo_EnabledChanged);
            this.btnToVehicleInfo.Click += new System.EventHandler(this.BtnToVehicleInfo_Click);
            // 
            // ucCustomerCardWithFilter1
            // 
            this.ucCustomerCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucCustomerCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCustomerCardWithFilter1.FilterEnabled = true;
            this.ucCustomerCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucCustomerCardWithFilter1.Name = "ucCustomerCardWithFilter1";
            this.ucCustomerCardWithFilter1.Size = new System.Drawing.Size(1047, 749);
            this.ucCustomerCardWithFilter1.TabIndex = 0;
            // 
            // tpVehicleInfo
            // 
            this.tpVehicleInfo.Controls.Add(this.btnToBookingInfo);
            this.tpVehicleInfo.Controls.Add(this.ucVehicleCardWithFilter1);
            this.tpVehicleInfo.Location = new System.Drawing.Point(4, 54);
            this.tpVehicleInfo.Name = "tpVehicleInfo";
            this.tpVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicleInfo.Size = new System.Drawing.Size(1053, 826);
            this.tpVehicleInfo.TabIndex = 1;
            this.tpVehicleInfo.Text = "Vehicle Info";
            this.tpVehicleInfo.UseVisualStyleBackColor = true;
            // 
            // btnToBookingInfo
            // 
            this.btnToBookingInfo.BorderRadius = 22;
            this.btnToBookingInfo.CustomizableEdges.TopRight = false;
            this.btnToBookingInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToBookingInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToBookingInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToBookingInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToBookingInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnToBookingInfo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBookingInfo.ForeColor = System.Drawing.Color.White;
            this.btnToBookingInfo.Image = global::CarRentalManagementSystem.Properties.Resources.next;
            this.btnToBookingInfo.Location = new System.Drawing.Point(876, 666);
            this.btnToBookingInfo.Name = "btnToBookingInfo";
            this.btnToBookingInfo.Size = new System.Drawing.Size(171, 53);
            this.btnToBookingInfo.TabIndex = 233;
            this.btnToBookingInfo.Text = "Next";
            this.btnToBookingInfo.EnabledChanged += new System.EventHandler(this.BtnToBookingInfo_EnabledChanged);
            this.btnToBookingInfo.Click += new System.EventHandler(this.BtnToBookingInfo_Click);
            // 
            // ucVehicleCardWithFilter1
            // 
            this.ucVehicleCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucVehicleCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucVehicleCardWithFilter1.FilterEnabled = true;
            this.ucVehicleCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucVehicleCardWithFilter1.Name = "ucVehicleCardWithFilter1";
            this.ucVehicleCardWithFilter1.Size = new System.Drawing.Size(1047, 654);
            this.ucVehicleCardWithFilter1.TabIndex = 0;
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.Controls.Add(this.btnSave);
            this.tpBookingInfo.Controls.Add(this.txtInitialCheckNotes);
            this.tpBookingInfo.Controls.Add(this.label11);
            this.tpBookingInfo.Controls.Add(this.txtPickUpLocation);
            this.tpBookingInfo.Controls.Add(this.label9);
            this.tpBookingInfo.Controls.Add(this.txtDropOffLocation);
            this.tpBookingInfo.Controls.Add(this.label10);
            this.tpBookingInfo.Controls.Add(this.txtRentalPricePerDay);
            this.tpBookingInfo.Controls.Add(this.label7);
            this.tpBookingInfo.Controls.Add(this.txtInitialTotalDueAmount);
            this.tpBookingInfo.Controls.Add(this.label8);
            this.tpBookingInfo.Controls.Add(this.label6);
            this.tpBookingInfo.Controls.Add(this.nudInitialRentalDays);
            this.tpBookingInfo.Controls.Add(this.label5);
            this.tpBookingInfo.Controls.Add(this.dtpEndDate);
            this.tpBookingInfo.Controls.Add(this.label4);
            this.tpBookingInfo.Controls.Add(this.dtpStartDate);
            this.tpBookingInfo.Controls.Add(this.txtBookingID);
            this.tpBookingInfo.Controls.Add(this.label3);
            this.tpBookingInfo.Controls.Add(this.txtVehicleID);
            this.tpBookingInfo.Controls.Add(this.label2);
            this.tpBookingInfo.Controls.Add(this.txtCustomerID);
            this.tpBookingInfo.Controls.Add(this.label1);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 54);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingInfo.Size = new System.Drawing.Size(1053, 826);
            this.tpBookingInfo.TabIndex = 2;
            this.tpBookingInfo.Text = "Booking Info";
            this.tpBookingInfo.UseVisualStyleBackColor = true;
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
            this.btnSave.Location = new System.Drawing.Point(422, 643);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(279, 66);
            this.btnSave.TabIndex = 262;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtInitialCheckNotes
            // 
            this.txtInitialCheckNotes.BorderRadius = 22;
            this.txtInitialCheckNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialCheckNotes.DefaultText = "";
            this.txtInitialCheckNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialCheckNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialCheckNotes.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtInitialCheckNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialCheckNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialCheckNotes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtInitialCheckNotes.ForeColor = System.Drawing.Color.Black;
            this.txtInitialCheckNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialCheckNotes.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtInitialCheckNotes.Location = new System.Drawing.Point(772, 425);
            this.txtInitialCheckNotes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtInitialCheckNotes.Name = "txtInitialCheckNotes";
            this.txtInitialCheckNotes.PasswordChar = '\0';
            this.txtInitialCheckNotes.PlaceholderText = "";
            this.txtInitialCheckNotes.SelectedText = "";
            this.txtInitialCheckNotes.Size = new System.Drawing.Size(229, 43);
            this.txtInitialCheckNotes.TabIndex = 261;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label11.Location = new System.Drawing.Point(561, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 21);
            this.label11.TabIndex = 260;
            this.label11.Text = "Initial Check Notes :";
            // 
            // txtPickUpLocation
            // 
            this.txtPickUpLocation.BorderRadius = 22;
            this.txtPickUpLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPickUpLocation.DefaultText = "";
            this.txtPickUpLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPickUpLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPickUpLocation.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtPickUpLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPickUpLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickUpLocation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtPickUpLocation.ForeColor = System.Drawing.Color.Black;
            this.txtPickUpLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickUpLocation.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtPickUpLocation.Location = new System.Drawing.Point(772, 279);
            this.txtPickUpLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPickUpLocation.Name = "txtPickUpLocation";
            this.txtPickUpLocation.PasswordChar = '\0';
            this.txtPickUpLocation.PlaceholderText = "";
            this.txtPickUpLocation.SelectedText = "";
            this.txtPickUpLocation.Size = new System.Drawing.Size(229, 43);
            this.txtPickUpLocation.TabIndex = 257;
            this.txtPickUpLocation.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label9.Location = new System.Drawing.Point(561, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 21);
            this.label9.TabIndex = 256;
            this.label9.Text = "Pick up Location :";
            // 
            // txtDropOffLocation
            // 
            this.txtDropOffLocation.BorderRadius = 22;
            this.txtDropOffLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDropOffLocation.DefaultText = "";
            this.txtDropOffLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDropOffLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDropOffLocation.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtDropOffLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDropOffLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDropOffLocation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDropOffLocation.ForeColor = System.Drawing.Color.Black;
            this.txtDropOffLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDropOffLocation.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtDropOffLocation.Location = new System.Drawing.Point(772, 352);
            this.txtDropOffLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDropOffLocation.Name = "txtDropOffLocation";
            this.txtDropOffLocation.PasswordChar = '\0';
            this.txtDropOffLocation.PlaceholderText = "";
            this.txtDropOffLocation.SelectedText = "";
            this.txtDropOffLocation.Size = new System.Drawing.Size(229, 43);
            this.txtDropOffLocation.TabIndex = 255;
            this.txtDropOffLocation.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label10.Location = new System.Drawing.Point(561, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 21);
            this.label10.TabIndex = 254;
            this.label10.Text = "Drop off Location :";
            // 
            // txtRentalPricePerDay
            // 
            this.txtRentalPricePerDay.BorderRadius = 22;
            this.txtRentalPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerDay.DefaultText = "N/A";
            this.txtRentalPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerDay.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtRentalPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerDay.Enabled = false;
            this.txtRentalPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerDay.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerDay.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtRentalPricePerDay.Location = new System.Drawing.Point(212, 498);
            this.txtRentalPricePerDay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRentalPricePerDay.Name = "txtRentalPricePerDay";
            this.txtRentalPricePerDay.PasswordChar = '\0';
            this.txtRentalPricePerDay.PlaceholderText = "";
            this.txtRentalPricePerDay.ReadOnly = true;
            this.txtRentalPricePerDay.SelectedText = "";
            this.txtRentalPricePerDay.Size = new System.Drawing.Size(229, 43);
            this.txtRentalPricePerDay.TabIndex = 253;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label7.Location = new System.Drawing.Point(26, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 21);
            this.label7.TabIndex = 252;
            this.label7.Text = "Rental Price Per Day :";
            // 
            // txtInitialTotalDueAmount
            // 
            this.txtInitialTotalDueAmount.BorderRadius = 22;
            this.txtInitialTotalDueAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialTotalDueAmount.DefaultText = "N/A";
            this.txtInitialTotalDueAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialTotalDueAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialTotalDueAmount.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtInitialTotalDueAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialTotalDueAmount.Enabled = false;
            this.txtInitialTotalDueAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialTotalDueAmount.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtInitialTotalDueAmount.ForeColor = System.Drawing.Color.Black;
            this.txtInitialTotalDueAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialTotalDueAmount.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtInitialTotalDueAmount.Location = new System.Drawing.Point(772, 206);
            this.txtInitialTotalDueAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtInitialTotalDueAmount.Name = "txtInitialTotalDueAmount";
            this.txtInitialTotalDueAmount.PasswordChar = '\0';
            this.txtInitialTotalDueAmount.PlaceholderText = "";
            this.txtInitialTotalDueAmount.ReadOnly = true;
            this.txtInitialTotalDueAmount.SelectedText = "";
            this.txtInitialTotalDueAmount.Size = new System.Drawing.Size(229, 43);
            this.txtInitialTotalDueAmount.TabIndex = 251;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(561, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 21);
            this.label8.TabIndex = 250;
            this.label8.Text = "Initial Total Due Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label6.Location = new System.Drawing.Point(26, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 249;
            this.label6.Text = "Initial Rental Days :";
            // 
            // nudInitialRentalDays
            // 
            this.nudInitialRentalDays.BackColor = System.Drawing.Color.Transparent;
            this.nudInitialRentalDays.BorderRadius = 22;
            this.nudInitialRentalDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudInitialRentalDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudInitialRentalDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudInitialRentalDays.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.nudInitialRentalDays.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.nudInitialRentalDays.Enabled = false;
            this.nudInitialRentalDays.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInitialRentalDays.Location = new System.Drawing.Point(212, 425);
            this.nudInitialRentalDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudInitialRentalDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudInitialRentalDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitialRentalDays.Name = "nudInitialRentalDays";
            this.nudInitialRentalDays.Size = new System.Drawing.Size(229, 43);
            this.nudInitialRentalDays.TabIndex = 248;
            this.nudInitialRentalDays.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.nudInitialRentalDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label5.Location = new System.Drawing.Point(26, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 214;
            this.label5.Text = "End Date :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 22;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dtpEndDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(212, 352);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(229, 43);
            this.dtpEndDate.TabIndex = 213;
            this.dtpEndDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.DtpEndDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label4.Location = new System.Drawing.Point(26, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 212;
            this.label4.Text = "Start Date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 22;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(212, 279);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(229, 43);
            this.dtpStartDate.TabIndex = 211;
            this.dtpStartDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // txtBookingID
            // 
            this.txtBookingID.BorderRadius = 22;
            this.txtBookingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingID.DefaultText = "N/A";
            this.txtBookingID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtBookingID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingID.Enabled = false;
            this.txtBookingID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.ForeColor = System.Drawing.Color.Red;
            this.txtBookingID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtBookingID.Location = new System.Drawing.Point(212, 133);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.PlaceholderText = "";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(229, 43);
            this.txtBookingID.TabIndex = 210;
            this.txtBookingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(26, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 209;
            this.label3.Text = "Booking ID :";
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
            this.txtVehicleID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleID.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtVehicleID.Location = new System.Drawing.Point(212, 206);
            this.txtVehicleID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.PasswordChar = '\0';
            this.txtVehicleID.PlaceholderText = "";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.SelectedText = "";
            this.txtVehicleID.Size = new System.Drawing.Size(229, 43);
            this.txtVehicleID.TabIndex = 208;
            this.txtVehicleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(26, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 207;
            this.label2.Text = "Vehicle ID :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderRadius = 22;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "N/A";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCustomerID.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtCustomerID.Location = new System.Drawing.Point(772, 133);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(229, 43);
            this.txtCustomerID.TabIndex = 206;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(561, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 205;
            this.label1.Text = "Customer ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddRentalBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 972);
            this.Controls.Add(this.tcRentalBooking);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddRentalBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddBooking";
            this.Load += new System.EventHandler(this.FrmAddRentalBooking_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcRentalBooking.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpVehicleInfo.ResumeLayout(false);
            this.tpBookingInfo.ResumeLayout(false);
            this.tpBookingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialRentalDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcRentalBooking;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private System.Windows.Forms.TabPage tpVehicleInfo;
        private Customers.UserControls.UcCustomerCardWithFilter ucCustomerCardWithFilter1;
        private Vehicles.UserControls.UcVehicleCardWithFilter ucVehicleCardWithFilter1;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudInitialRentalDays;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerDay;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtInitialTotalDueAmount;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtInitialCheckNotes;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtPickUpLocation;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtDropOffLocation;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnToVehicleInfo;
        private Guna.UI2.WinForms.Guna2Button btnToBookingInfo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
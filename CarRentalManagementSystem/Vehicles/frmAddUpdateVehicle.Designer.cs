namespace CarRentalManagementSystem.Vehicles
{
    partial class FrmAddUpdateVehicle
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMakes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtVehicleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtVehicleID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModels = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuelTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSubModels = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDriveTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEngine = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudNumberOfDoors = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRentalPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbIsAvailableForRent = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDoors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 22;
            this.btnClose.CustomizableEdges.TopRight = false;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::CarRentalManagementSystem.Properties.Resources.cross_mark_on_a_black_circle_background;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(207, 615);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 58);
            this.btnClose.TabIndex = 232;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label12.Location = new System.Drawing.Point(28, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 21);
            this.label12.TabIndex = 228;
            this.label12.Text = "Make : ";
            // 
            // cbMakes
            // 
            this.cbMakes.BackColor = System.Drawing.Color.Transparent;
            this.cbMakes.BorderRadius = 22;
            this.cbMakes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbMakes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbMakes.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.cbMakes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMakes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMakes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMakes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbMakes.ForeColor = System.Drawing.Color.Black;
            this.cbMakes.ItemHeight = 37;
            this.cbMakes.Location = new System.Drawing.Point(172, 268);
            this.cbMakes.Name = "cbMakes";
            this.cbMakes.Size = new System.Drawing.Size(342, 43);
            this.cbMakes.TabIndex = 227;
            this.cbMakes.SelectedIndexChanged += new System.EventHandler(this.CbMakes_SelectedIndexChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.car_manufacturing;
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
            this.lblTitle.Size = new System.Drawing.Size(189, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Vehicle";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 22;
            this.btnSave.CustomizableEdges.TopRight = false;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CarRentalManagementSystem.Properties.Resources.folder;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(24, 615);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 58);
            this.btnSave.TabIndex = 231;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.BorderRadius = 22;
            this.txtVehicleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleName.DefaultText = "";
            this.txtVehicleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVehicleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVehicleName.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleName.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtVehicleName.Location = new System.Drawing.Point(172, 202);
            this.txtVehicleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.PasswordChar = '\0';
            this.txtVehicleName.PlaceholderText = "";
            this.txtVehicleName.SelectedText = "";
            this.txtVehicleName.Size = new System.Drawing.Size(342, 43);
            this.txtVehicleName.TabIndex = 217;
            this.txtVehicleName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtVehicleName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(28, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 216;
            this.label8.Text = "Vehicle Name :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.BorderRadius = 22;
            this.txtVehicleID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleID.DefaultText = "N/A";
            this.txtVehicleID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleID.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtVehicleID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleID.Enabled = false;
            this.txtVehicleID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVehicleID.ForeColor = System.Drawing.Color.Red;
            this.txtVehicleID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtVehicleID.Location = new System.Drawing.Point(461, 110);
            this.txtVehicleID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.PasswordChar = '\0';
            this.txtVehicleID.PlaceholderText = "";
            this.txtVehicleID.SelectedText = "";
            this.txtVehicleID.Size = new System.Drawing.Size(342, 43);
            this.txtVehicleID.TabIndex = 204;
            this.txtVehicleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(343, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 203;
            this.label1.Text = "Vehicle ID :";
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1210, 88);
            this.guna2GradientPanel1.TabIndex = 202;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(28, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 234;
            this.label2.Text = "Model :";
            // 
            // cbModels
            // 
            this.cbModels.BackColor = System.Drawing.Color.Transparent;
            this.cbModels.BorderRadius = 22;
            this.cbModels.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbModels.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbModels.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.cbModels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModels.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModels.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModels.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbModels.ForeColor = System.Drawing.Color.Black;
            this.cbModels.ItemHeight = 37;
            this.cbModels.Location = new System.Drawing.Point(172, 334);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(342, 43);
            this.cbModels.TabIndex = 233;
            this.cbModels.SelectedIndexChanged += new System.EventHandler(this.CbModels_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(28, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 238;
            this.label3.Text = "Fuel Type :";
            // 
            // cbFuelTypes
            // 
            this.cbFuelTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbFuelTypes.BorderRadius = 22;
            this.cbFuelTypes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbFuelTypes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbFuelTypes.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.cbFuelTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFuelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuelTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuelTypes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbFuelTypes.ForeColor = System.Drawing.Color.Black;
            this.cbFuelTypes.ItemHeight = 37;
            this.cbFuelTypes.Location = new System.Drawing.Point(172, 466);
            this.cbFuelTypes.Name = "cbFuelTypes";
            this.cbFuelTypes.Size = new System.Drawing.Size(342, 43);
            this.cbFuelTypes.TabIndex = 237;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label4.Location = new System.Drawing.Point(28, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 236;
            this.label4.Text = "Sub-Model :";
            // 
            // cbSubModels
            // 
            this.cbSubModels.BackColor = System.Drawing.Color.Transparent;
            this.cbSubModels.BorderRadius = 22;
            this.cbSubModels.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbSubModels.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbSubModels.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.cbSubModels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubModels.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubModels.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubModels.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbSubModels.ForeColor = System.Drawing.Color.Black;
            this.cbSubModels.ItemHeight = 37;
            this.cbSubModels.Location = new System.Drawing.Point(172, 400);
            this.cbSubModels.Name = "cbSubModels";
            this.cbSubModels.Size = new System.Drawing.Size(342, 43);
            this.cbSubModels.TabIndex = 235;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label5.Location = new System.Drawing.Point(28, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 240;
            this.label5.Text = "Drive Type :";
            // 
            // cbDriveTypes
            // 
            this.cbDriveTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbDriveTypes.BorderRadius = 22;
            this.cbDriveTypes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbDriveTypes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbDriveTypes.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.cbDriveTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDriveTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriveTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDriveTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDriveTypes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbDriveTypes.ForeColor = System.Drawing.Color.Black;
            this.cbDriveTypes.ItemHeight = 37;
            this.cbDriveTypes.Location = new System.Drawing.Point(172, 532);
            this.cbDriveTypes.Name = "cbDriveTypes";
            this.cbDriveTypes.Size = new System.Drawing.Size(342, 43);
            this.cbDriveTypes.TabIndex = 239;
            // 
            // txtYear
            // 
            this.txtYear.BorderRadius = 22;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtYear.Location = new System.Drawing.Point(828, 202);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PlaceholderText = "";
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(342, 43);
            this.txtYear.TabIndex = 242;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.TxtYear_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label6.Location = new System.Drawing.Point(630, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 241;
            this.label6.Text = "Year : ";
            // 
            // txtMileage
            // 
            this.txtMileage.BorderRadius = 22;
            this.txtMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileage.DefaultText = "";
            this.txtMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtMileage.ForeColor = System.Drawing.Color.Black;
            this.txtMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtMileage.Location = new System.Drawing.Point(828, 334);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PasswordChar = '\0';
            this.txtMileage.PlaceholderText = "";
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(342, 43);
            this.txtMileage.TabIndex = 246;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label7.Location = new System.Drawing.Point(630, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 245;
            this.label7.Text = "Mileage :";
            // 
            // txtEngine
            // 
            this.txtEngine.BorderRadius = 22;
            this.txtEngine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEngine.DefaultText = "";
            this.txtEngine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEngine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEngine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEngine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEngine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEngine.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEngine.ForeColor = System.Drawing.Color.Black;
            this.txtEngine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEngine.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtEngine.Location = new System.Drawing.Point(828, 268);
            this.txtEngine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEngine.Multiline = true;
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.PasswordChar = '\0';
            this.txtEngine.PlaceholderText = "";
            this.txtEngine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEngine.SelectedText = "";
            this.txtEngine.Size = new System.Drawing.Size(342, 43);
            this.txtEngine.TabIndex = 244;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label9.Location = new System.Drawing.Point(630, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 243;
            this.label9.Text = "Engine :";
            // 
            // nudNumberOfDoors
            // 
            this.nudNumberOfDoors.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfDoors.BorderRadius = 22;
            this.nudNumberOfDoors.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfDoors.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.nudNumberOfDoors.Location = new System.Drawing.Point(828, 400);
            this.nudNumberOfDoors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNumberOfDoors.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNumberOfDoors.Name = "nudNumberOfDoors";
            this.nudNumberOfDoors.Size = new System.Drawing.Size(342, 43);
            this.nudNumberOfDoors.TabIndex = 247;
            this.nudNumberOfDoors.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label10.Location = new System.Drawing.Point(630, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 21);
            this.label10.TabIndex = 248;
            this.label10.Text = "Number Of Doors :";
            // 
            // txtRentalPricePerDay
            // 
            this.txtRentalPricePerDay.BorderRadius = 22;
            this.txtRentalPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalPricePerDay.DefaultText = "";
            this.txtRentalPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalPricePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerDay.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtRentalPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalPricePerDay.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtRentalPricePerDay.Location = new System.Drawing.Point(828, 466);
            this.txtRentalPricePerDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRentalPricePerDay.Name = "txtRentalPricePerDay";
            this.txtRentalPricePerDay.PasswordChar = '\0';
            this.txtRentalPricePerDay.PlaceholderText = "";
            this.txtRentalPricePerDay.SelectedText = "";
            this.txtRentalPricePerDay.Size = new System.Drawing.Size(342, 43);
            this.txtRentalPricePerDay.TabIndex = 250;
            this.txtRentalPricePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRentalPricePerDay_KeyPress);
            this.txtRentalPricePerDay.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRentalPricePerDay_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label11.Location = new System.Drawing.Point(630, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 21);
            this.label11.TabIndex = 249;
            this.label11.Text = "Rental Price Per Day :";
            // 
            // ckbIsAvailableForRent
            // 
            this.ckbIsAvailableForRent.AutoSize = true;
            this.ckbIsAvailableForRent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbIsAvailableForRent.CheckedState.BorderRadius = 0;
            this.ckbIsAvailableForRent.CheckedState.BorderThickness = 0;
            this.ckbIsAvailableForRent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbIsAvailableForRent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ckbIsAvailableForRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.ckbIsAvailableForRent.Location = new System.Drawing.Point(828, 540);
            this.ckbIsAvailableForRent.Name = "ckbIsAvailableForRent";
            this.ckbIsAvailableForRent.Size = new System.Drawing.Size(203, 28);
            this.ckbIsAvailableForRent.TabIndex = 251;
            this.ckbIsAvailableForRent.Text = "Is Available For Rent";
            this.ckbIsAvailableForRent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbIsAvailableForRent.UncheckedState.BorderRadius = 0;
            this.ckbIsAvailableForRent.UncheckedState.BorderThickness = 0;
            this.ckbIsAvailableForRent.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label13.Location = new System.Drawing.Point(630, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 252;
            this.label13.Text = "Status : ";
            // 
            // frmAddUpdateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 686);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ckbIsAvailableForRent);
            this.Controls.Add(this.txtRentalPricePerDay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudNumberOfDoors);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDriveTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFuelTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSubModels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModels);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMakes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVehicleName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateVehicle";
            this.Load += new System.EventHandler(this.FrmAddUpdateVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDoors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cbMakes;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbModels;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbDriveTypes;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbFuelTypes;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubModels;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtMileage;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtEngine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfDoors;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalPricePerDay;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2CheckBox ckbIsAvailableForRent;
        private System.Windows.Forms.Label label13;
    }
}
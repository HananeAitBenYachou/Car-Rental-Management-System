namespace CarRentalManagementSystem.Returns
{
    partial class FrmReturnRentedVehicle
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcReturnVehicle = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.ucBookingDetailsWithFilter1 = new CarRentalManagementSystem.Bookings.UserControls.UcBookingDetailsWithFilter();
            this.tpReturnInfo = new System.Windows.Forms.TabPage();
            this.txtFinalCheckNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdditionalCharges = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsumedMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtActualTotalDueAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudActualRentalDays = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpActualReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtReturnID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransactionID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcReturnVehicle.SuspendLayout();
            this.tpBookingInfo.SuspendLayout();
            this.tpReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudActualRentalDays)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tcReturnVehicle
            // 
            this.tcReturnVehicle.Controls.Add(this.tpBookingInfo);
            this.tcReturnVehicle.Controls.Add(this.tpReturnInfo);
            this.tcReturnVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcReturnVehicle.ItemSize = new System.Drawing.Size(180, 50);
            this.tcReturnVehicle.Location = new System.Drawing.Point(0, 88);
            this.tcReturnVehicle.Name = "tcReturnVehicle";
            this.tcReturnVehicle.SelectedIndex = 0;
            this.tcReturnVehicle.Size = new System.Drawing.Size(1061, 762);
            this.tcReturnVehicle.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcReturnVehicle.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcReturnVehicle.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReturnVehicle.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcReturnVehicle.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcReturnVehicle.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcReturnVehicle.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcReturnVehicle.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReturnVehicle.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcReturnVehicle.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcReturnVehicle.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcReturnVehicle.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcReturnVehicle.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReturnVehicle.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcReturnVehicle.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.tcReturnVehicle.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcReturnVehicle.TabIndex = 206;
            this.tcReturnVehicle.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcReturnVehicle.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.Controls.Add(this.ucBookingDetailsWithFilter1);
            this.tpBookingInfo.Controls.Add(this.btnClose);
            this.tpBookingInfo.Controls.Add(this.btnNext);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 54);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingInfo.Size = new System.Drawing.Size(1053, 704);
            this.tpBookingInfo.TabIndex = 0;
            this.tpBookingInfo.Text = "Booking Info";
            this.tpBookingInfo.UseVisualStyleBackColor = true;
            // 
            // ucBookingDetailsWithFilter1
            // 
            this.ucBookingDetailsWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucBookingDetailsWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBookingDetailsWithFilter1.FilterEnabled = true;
            this.ucBookingDetailsWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ucBookingDetailsWithFilter1.Name = "ucBookingDetailsWithFilter1";
            this.ucBookingDetailsWithFilter1.Size = new System.Drawing.Size(1047, 616);
            this.ucBookingDetailsWithFilter1.TabIndex = 234;
            // 
            // tpReturnInfo
            // 
            this.tpReturnInfo.Controls.Add(this.btnSave);
            this.tpReturnInfo.Controls.Add(this.txtFinalCheckNotes);
            this.tpReturnInfo.Controls.Add(this.label11);
            this.tpReturnInfo.Controls.Add(this.txtAdditionalCharges);
            this.tpReturnInfo.Controls.Add(this.label9);
            this.tpReturnInfo.Controls.Add(this.txtMileage);
            this.tpReturnInfo.Controls.Add(this.label10);
            this.tpReturnInfo.Controls.Add(this.txtConsumedMileage);
            this.tpReturnInfo.Controls.Add(this.label7);
            this.tpReturnInfo.Controls.Add(this.txtActualTotalDueAmount);
            this.tpReturnInfo.Controls.Add(this.label8);
            this.tpReturnInfo.Controls.Add(this.label6);
            this.tpReturnInfo.Controls.Add(this.nudActualRentalDays);
            this.tpReturnInfo.Controls.Add(this.label5);
            this.tpReturnInfo.Controls.Add(this.dtpActualReturnDate);
            this.tpReturnInfo.Controls.Add(this.txtReturnID);
            this.tpReturnInfo.Controls.Add(this.label3);
            this.tpReturnInfo.Controls.Add(this.txtTransactionID);
            this.tpReturnInfo.Controls.Add(this.label1);
            this.tpReturnInfo.Location = new System.Drawing.Point(4, 54);
            this.tpReturnInfo.Name = "tpReturnInfo";
            this.tpReturnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReturnInfo.Size = new System.Drawing.Size(1053, 704);
            this.tpReturnInfo.TabIndex = 2;
            this.tpReturnInfo.Text = "Return Info";
            this.tpReturnInfo.UseVisualStyleBackColor = true;
            // 
            // txtFinalCheckNotes
            // 
            this.txtFinalCheckNotes.BorderRadius = 22;
            this.txtFinalCheckNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinalCheckNotes.DefaultText = "";
            this.txtFinalCheckNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalCheckNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalCheckNotes.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtFinalCheckNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalCheckNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtFinalCheckNotes.ForeColor = System.Drawing.Color.Black;
            this.txtFinalCheckNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtFinalCheckNotes.Location = new System.Drawing.Point(210, 362);
            this.txtFinalCheckNotes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFinalCheckNotes.Name = "txtFinalCheckNotes";
            this.txtFinalCheckNotes.PasswordChar = '\0';
            this.txtFinalCheckNotes.PlaceholderText = "";
            this.txtFinalCheckNotes.SelectedText = "";
            this.txtFinalCheckNotes.Size = new System.Drawing.Size(803, 99);
            this.txtFinalCheckNotes.TabIndex = 261;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label11.Location = new System.Drawing.Point(31, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 21);
            this.label11.TabIndex = 260;
            this.label11.Text = "Final Check Notes :";
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.BorderRadius = 22;
            this.txtAdditionalCharges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalCharges.DefaultText = "";
            this.txtAdditionalCharges.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalCharges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalCharges.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdditionalCharges.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalCharges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdditionalCharges.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalCharges.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtAdditionalCharges.Location = new System.Drawing.Point(784, 208);
            this.txtAdditionalCharges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.PasswordChar = '\0';
            this.txtAdditionalCharges.PlaceholderText = "";
            this.txtAdditionalCharges.SelectedText = "";
            this.txtAdditionalCharges.Size = new System.Drawing.Size(229, 43);
            this.txtAdditionalCharges.TabIndex = 257;
            this.txtAdditionalCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label9.Location = new System.Drawing.Point(573, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 21);
            this.label9.TabIndex = 256;
            this.label9.Text = "Additional Charges :";
            // 
            // txtMileage
            // 
            this.txtMileage.BorderRadius = 22;
            this.txtMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileage.DefaultText = "";
            this.txtMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtMileage.ForeColor = System.Drawing.Color.Black;
            this.txtMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtMileage.Location = new System.Drawing.Point(784, 285);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PasswordChar = '\0';
            this.txtMileage.PlaceholderText = "";
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(229, 43);
            this.txtMileage.TabIndex = 255;
            this.txtMileage.TextChanged += new System.EventHandler(this.TxtMileage_TextChanged);
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.txtMileage.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMileage_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label10.Location = new System.Drawing.Point(573, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 254;
            this.label10.Text = "Mileage :";
            // 
            // txtConsumedMileage
            // 
            this.txtConsumedMileage.BorderRadius = 22;
            this.txtConsumedMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsumedMileage.DefaultText = "N/A";
            this.txtConsumedMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsumedMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsumedMileage.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtConsumedMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsumedMileage.Enabled = false;
            this.txtConsumedMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsumedMileage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumedMileage.ForeColor = System.Drawing.Color.Black;
            this.txtConsumedMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsumedMileage.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtConsumedMileage.Location = new System.Drawing.Point(210, 285);
            this.txtConsumedMileage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConsumedMileage.Name = "txtConsumedMileage";
            this.txtConsumedMileage.PasswordChar = '\0';
            this.txtConsumedMileage.PlaceholderText = "";
            this.txtConsumedMileage.ReadOnly = true;
            this.txtConsumedMileage.SelectedText = "";
            this.txtConsumedMileage.Size = new System.Drawing.Size(229, 43);
            this.txtConsumedMileage.TabIndex = 253;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label7.Location = new System.Drawing.Point(31, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 252;
            this.label7.Text = "Consumed Mileage :";
            // 
            // txtActualTotalDueAmount
            // 
            this.txtActualTotalDueAmount.BorderRadius = 22;
            this.txtActualTotalDueAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualTotalDueAmount.DefaultText = "N/A";
            this.txtActualTotalDueAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualTotalDueAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualTotalDueAmount.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtActualTotalDueAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualTotalDueAmount.Enabled = false;
            this.txtActualTotalDueAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualTotalDueAmount.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtActualTotalDueAmount.ForeColor = System.Drawing.Color.Black;
            this.txtActualTotalDueAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualTotalDueAmount.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtActualTotalDueAmount.Location = new System.Drawing.Point(784, 131);
            this.txtActualTotalDueAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtActualTotalDueAmount.Name = "txtActualTotalDueAmount";
            this.txtActualTotalDueAmount.PasswordChar = '\0';
            this.txtActualTotalDueAmount.PlaceholderText = "";
            this.txtActualTotalDueAmount.ReadOnly = true;
            this.txtActualTotalDueAmount.SelectedText = "";
            this.txtActualTotalDueAmount.Size = new System.Drawing.Size(229, 43);
            this.txtActualTotalDueAmount.TabIndex = 251;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(573, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 21);
            this.label8.TabIndex = 250;
            this.label8.Text = "Actual Total Due Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label6.Location = new System.Drawing.Point(31, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 249;
            this.label6.Text = "Actual Rental Days :";
            // 
            // nudActualRentalDays
            // 
            this.nudActualRentalDays.BackColor = System.Drawing.Color.Transparent;
            this.nudActualRentalDays.BorderRadius = 22;
            this.nudActualRentalDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudActualRentalDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudActualRentalDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudActualRentalDays.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.nudActualRentalDays.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.nudActualRentalDays.Enabled = false;
            this.nudActualRentalDays.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudActualRentalDays.Location = new System.Drawing.Point(210, 208);
            this.nudActualRentalDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudActualRentalDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudActualRentalDays.Name = "nudActualRentalDays";
            this.nudActualRentalDays.Size = new System.Drawing.Size(229, 43);
            this.nudActualRentalDays.TabIndex = 248;
            this.nudActualRentalDays.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.nudActualRentalDays.Value = new decimal(new int[] {
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
            this.label5.Location = new System.Drawing.Point(31, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 214;
            this.label5.Text = "Actual Return Date :";
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.BorderRadius = 22;
            this.dtpActualReturnDate.Checked = true;
            this.dtpActualReturnDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dtpActualReturnDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActualReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpActualReturnDate.Location = new System.Drawing.Point(210, 131);
            this.dtpActualReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpActualReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(229, 43);
            this.dtpActualReturnDate.TabIndex = 213;
            this.dtpActualReturnDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            this.dtpActualReturnDate.ValueChanged += new System.EventHandler(this.DtpActualReturnDate_ValueChanged);
            // 
            // txtReturnID
            // 
            this.txtReturnID.BorderRadius = 22;
            this.txtReturnID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReturnID.DefaultText = "N/A";
            this.txtReturnID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturnID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturnID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtReturnID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturnID.Enabled = false;
            this.txtReturnID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturnID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnID.ForeColor = System.Drawing.Color.Red;
            this.txtReturnID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturnID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtReturnID.Location = new System.Drawing.Point(210, 54);
            this.txtReturnID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.PasswordChar = '\0';
            this.txtReturnID.PlaceholderText = "";
            this.txtReturnID.ReadOnly = true;
            this.txtReturnID.SelectedText = "";
            this.txtReturnID.Size = new System.Drawing.Size(229, 43);
            this.txtReturnID.TabIndex = 210;
            this.txtReturnID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 209;
            this.label3.Text = "Return ID :";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.BorderRadius = 22;
            this.txtTransactionID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransactionID.DefaultText = "N/A";
            this.txtTransactionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransactionID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransactionID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtTransactionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransactionID.Enabled = false;
            this.txtTransactionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransactionID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtTransactionID.ForeColor = System.Drawing.Color.Black;
            this.txtTransactionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransactionID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtTransactionID.Location = new System.Drawing.Point(784, 54);
            this.txtTransactionID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.PasswordChar = '\0';
            this.txtTransactionID.PlaceholderText = "";
            this.txtTransactionID.ReadOnly = true;
            this.txtTransactionID.SelectedText = "";
            this.txtTransactionID.Size = new System.Drawing.Size(229, 43);
            this.txtTransactionID.TabIndex = 206;
            this.txtTransactionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(573, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 205;
            this.label1.Text = "Transaction ID :";
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
            this.guna2GradientPanel1.TabIndex = 205;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Return Vehicle";
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
            this.btnClose.Location = new System.Drawing.Point(3, 631);
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
            this.btnNext.Location = new System.Drawing.Point(879, 631);
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
            this.btnSave.Location = new System.Drawing.Point(835, 487);
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
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.rental1;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(28, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // FrmReturnRentedVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 850);
            this.Controls.Add(this.tcReturnVehicle);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReturnRentedVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturnRentedVehicle";
            this.Load += new System.EventHandler(this.FrmAddRentalBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcReturnVehicle.ResumeLayout(false);
            this.tpBookingInfo.ResumeLayout(false);
            this.tpReturnInfo.ResumeLayout(false);
            this.tpReturnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudActualRentalDays)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TabControl tcReturnVehicle;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage tpReturnInfo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtFinalCheckNotes;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalCharges;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtMileage;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtConsumedMileage;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtActualTotalDueAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudActualRentalDays;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpActualReturnDate;
        private Guna.UI2.WinForms.Guna2TextBox txtReturnID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTransactionID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Bookings.UserControls.UcBookingDetailsWithFilter ucBookingDetailsWithFilter1;
    }
}
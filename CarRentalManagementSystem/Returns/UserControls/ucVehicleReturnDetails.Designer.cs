namespace CarRentalManagementSystem.Returns.UserControls
{
    partial class UcVehicleReturnDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsumedMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFinalCheckNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtActualTotalDueAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpActualReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtReturnID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransactionID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudActualRentalDays = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdditionalCharges = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudActualRentalDays)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.Silver;
            this.groupBox.Controls.Add(this.txtAdditionalCharges);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.nudActualRentalDays);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.txtConsumedMileage);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.txtMileage);
            this.groupBox.Controls.Add(this.txtFinalCheckNotes);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.txtActualTotalDueAmount);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.dtpActualReturnDate);
            this.groupBox.Controls.Add(this.txtReturnID);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtTransactionID);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1017, 434);
            this.groupBox.TabIndex = 4;
            this.groupBox.Text = "Return Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label7.Location = new System.Drawing.Point(532, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 289;
            this.label7.Text = "Consumed Mileage :";
            // 
            // txtConsumedMileage
            // 
            this.txtConsumedMileage.BorderRadius = 22;
            this.txtConsumedMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsumedMileage.DefaultText = "";
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
            this.txtConsumedMileage.Location = new System.Drawing.Point(760, 197);
            this.txtConsumedMileage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConsumedMileage.Name = "txtConsumedMileage";
            this.txtConsumedMileage.PasswordChar = '\0';
            this.txtConsumedMileage.PlaceholderText = "";
            this.txtConsumedMileage.ReadOnly = true;
            this.txtConsumedMileage.SelectedText = "";
            this.txtConsumedMileage.Size = new System.Drawing.Size(229, 43);
            this.txtConsumedMileage.TabIndex = 288;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label6.Location = new System.Drawing.Point(532, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 287;
            this.label6.Text = "Mileage :";
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
            this.txtMileage.Enabled = false;
            this.txtMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileage.ForeColor = System.Drawing.Color.Black;
            this.txtMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtMileage.Location = new System.Drawing.Point(760, 127);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PasswordChar = '\0';
            this.txtMileage.PlaceholderText = "";
            this.txtMileage.ReadOnly = true;
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(229, 43);
            this.txtMileage.TabIndex = 286;
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
            this.txtFinalCheckNotes.Enabled = false;
            this.txtFinalCheckNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalCheckNotes.ForeColor = System.Drawing.Color.Black;
            this.txtFinalCheckNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtFinalCheckNotes.Location = new System.Drawing.Point(233, 340);
            this.txtFinalCheckNotes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFinalCheckNotes.Name = "txtFinalCheckNotes";
            this.txtFinalCheckNotes.PasswordChar = '\0';
            this.txtFinalCheckNotes.PlaceholderText = "";
            this.txtFinalCheckNotes.SelectedText = "";
            this.txtFinalCheckNotes.Size = new System.Drawing.Size(756, 66);
            this.txtFinalCheckNotes.TabIndex = 281;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label9.Location = new System.Drawing.Point(532, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 21);
            this.label9.TabIndex = 280;
            this.label9.Text = "Actual Total Due Amount :";
            // 
            // txtActualTotalDueAmount
            // 
            this.txtActualTotalDueAmount.BorderRadius = 22;
            this.txtActualTotalDueAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualTotalDueAmount.DefaultText = "";
            this.txtActualTotalDueAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualTotalDueAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualTotalDueAmount.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtActualTotalDueAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualTotalDueAmount.Enabled = false;
            this.txtActualTotalDueAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualTotalDueAmount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualTotalDueAmount.ForeColor = System.Drawing.Color.Black;
            this.txtActualTotalDueAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualTotalDueAmount.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtActualTotalDueAmount.Location = new System.Drawing.Point(760, 57);
            this.txtActualTotalDueAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtActualTotalDueAmount.Name = "txtActualTotalDueAmount";
            this.txtActualTotalDueAmount.PasswordChar = '\0';
            this.txtActualTotalDueAmount.PlaceholderText = "";
            this.txtActualTotalDueAmount.ReadOnly = true;
            this.txtActualTotalDueAmount.SelectedText = "";
            this.txtActualTotalDueAmount.Size = new System.Drawing.Size(229, 43);
            this.txtActualTotalDueAmount.TabIndex = 275;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(15, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 274;
            this.label8.Text = "Final Check Notes :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label5.Location = new System.Drawing.Point(532, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 271;
            this.label5.Text = "Additional Charges :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label4.Location = new System.Drawing.Point(15, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 269;
            this.label4.Text = "Actual Return Date :";
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.BorderRadius = 22;
            this.dtpActualReturnDate.Checked = true;
            this.dtpActualReturnDate.Enabled = false;
            this.dtpActualReturnDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dtpActualReturnDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActualReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpActualReturnDate.Location = new System.Drawing.Point(233, 197);
            this.dtpActualReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpActualReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(229, 43);
            this.dtpActualReturnDate.TabIndex = 268;
            this.dtpActualReturnDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // txtReturnID
            // 
            this.txtReturnID.BorderRadius = 22;
            this.txtReturnID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReturnID.DefaultText = "N/A";
            this.txtReturnID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturnID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturnID.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.txtReturnID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturnID.Enabled = false;
            this.txtReturnID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturnID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnID.ForeColor = System.Drawing.Color.Red;
            this.txtReturnID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturnID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtReturnID.Location = new System.Drawing.Point(233, 57);
            this.txtReturnID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.PasswordChar = '\0';
            this.txtReturnID.PlaceholderText = "";
            this.txtReturnID.ReadOnly = true;
            this.txtReturnID.SelectedText = "";
            this.txtReturnID.Size = new System.Drawing.Size(229, 43);
            this.txtReturnID.TabIndex = 267;
            this.txtReturnID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 266;
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
            this.txtTransactionID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionID.ForeColor = System.Drawing.Color.Black;
            this.txtTransactionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransactionID.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtTransactionID.Location = new System.Drawing.Point(233, 127);
            this.txtTransactionID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.PasswordChar = '\0';
            this.txtTransactionID.PlaceholderText = "";
            this.txtTransactionID.ReadOnly = true;
            this.txtTransactionID.SelectedText = "";
            this.txtTransactionID.Size = new System.Drawing.Size(229, 43);
            this.txtTransactionID.TabIndex = 265;
            this.txtTransactionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(15, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 264;
            this.label2.Text = "Transaction ID :";
            // 
            // nudActualRentalDays
            // 
            this.nudActualRentalDays.BackColor = System.Drawing.Color.Transparent;
            this.nudActualRentalDays.BorderRadius = 22;
            this.nudActualRentalDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudActualRentalDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudActualRentalDays.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.nudActualRentalDays.Enabled = false;
            this.nudActualRentalDays.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudActualRentalDays.Location = new System.Drawing.Point(233, 267);
            this.nudActualRentalDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudActualRentalDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudActualRentalDays.Name = "nudActualRentalDays";
            this.nudActualRentalDays.Size = new System.Drawing.Size(229, 43);
            this.nudActualRentalDays.TabIndex = 290;
            this.nudActualRentalDays.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(15, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 291;
            this.label1.Text = "Actual Rental  Days :";
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
            this.txtAdditionalCharges.Enabled = false;
            this.txtAdditionalCharges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalCharges.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalCharges.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtAdditionalCharges.Location = new System.Drawing.Point(760, 267);
            this.txtAdditionalCharges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.PasswordChar = '\0';
            this.txtAdditionalCharges.PlaceholderText = "";
            this.txtAdditionalCharges.ReadOnly = true;
            this.txtAdditionalCharges.SelectedText = "";
            this.txtAdditionalCharges.Size = new System.Drawing.Size(229, 43);
            this.txtAdditionalCharges.TabIndex = 292;
            // 
            // ucVehicleReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox);
            this.Name = "ucVehicleReturnDetails";
            this.Size = new System.Drawing.Size(1017, 434);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudActualRentalDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtConsumedMileage;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtMileage;
        private Guna.UI2.WinForms.Guna2TextBox txtFinalCheckNotes;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtActualTotalDueAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpActualReturnDate;
        private Guna.UI2.WinForms.Guna2TextBox txtReturnID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTransactionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudActualRentalDays;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalCharges;
    }
}

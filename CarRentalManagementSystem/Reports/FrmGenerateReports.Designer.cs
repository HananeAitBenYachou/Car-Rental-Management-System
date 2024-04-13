namespace CarRentalManagementSystem.Reports
{
    partial class FrmGenerateReport
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVehiclesListReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomersListReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnRentalBookingsReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactionsReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicleReturnsReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaintenancesReport = new Guna.UI2.WinForms.Guna2Button();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnProfitReport = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(33, 83);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1188, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.lblTitle.Location = new System.Drawing.Point(98, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Reports";
            // 
            // btnVehiclesListReport
            // 
            this.btnVehiclesListReport.BorderRadius = 22;
            this.btnVehiclesListReport.CustomizableEdges.BottomRight = false;
            this.btnVehiclesListReport.CustomizableEdges.TopRight = false;
            this.btnVehiclesListReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehiclesListReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehiclesListReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehiclesListReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehiclesListReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnVehiclesListReport.Font = new System.Drawing.Font("Calibri", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnVehiclesListReport.ForeColor = System.Drawing.Color.White;
            this.btnVehiclesListReport.Location = new System.Drawing.Point(30, 123);
            this.btnVehiclesListReport.Name = "btnVehiclesListReport";
            this.btnVehiclesListReport.Size = new System.Drawing.Size(165, 62);
            this.btnVehiclesListReport.TabIndex = 6;
            this.btnVehiclesListReport.Text = "Vehicles List";
            this.btnVehiclesListReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnVehiclesListReport.Click += new System.EventHandler(this.BtnVehiclesListReport_Click);
            // 
            // btnCustomersListReport
            // 
            this.btnCustomersListReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomersListReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomersListReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomersListReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomersListReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnCustomersListReport.Font = new System.Drawing.Font("Calibri", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnCustomersListReport.ForeColor = System.Drawing.Color.White;
            this.btnCustomersListReport.Location = new System.Drawing.Point(201, 123);
            this.btnCustomersListReport.Name = "btnCustomersListReport";
            this.btnCustomersListReport.Size = new System.Drawing.Size(165, 62);
            this.btnCustomersListReport.TabIndex = 7;
            this.btnCustomersListReport.Text = "Customers List";
            this.btnCustomersListReport.Click += new System.EventHandler(this.BtnCustomersListReport_Click);
            // 
            // btnRentalBookingsReport
            // 
            this.btnRentalBookingsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRentalBookingsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRentalBookingsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRentalBookingsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRentalBookingsReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnRentalBookingsReport.Font = new System.Drawing.Font("Calibri", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnRentalBookingsReport.ForeColor = System.Drawing.Color.White;
            this.btnRentalBookingsReport.Location = new System.Drawing.Point(372, 123);
            this.btnRentalBookingsReport.Name = "btnRentalBookingsReport";
            this.btnRentalBookingsReport.Size = new System.Drawing.Size(165, 62);
            this.btnRentalBookingsReport.TabIndex = 8;
            this.btnRentalBookingsReport.Text = "Rental Bookings Report";
            this.btnRentalBookingsReport.Click += new System.EventHandler(this.BtnRentalBookingsReport_Click);
            // 
            // btnTransactionsReport
            // 
            this.btnTransactionsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactionsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactionsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactionsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactionsReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnTransactionsReport.Font = new System.Drawing.Font("Calibri", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnTransactionsReport.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsReport.Location = new System.Drawing.Point(543, 123);
            this.btnTransactionsReport.Name = "btnTransactionsReport";
            this.btnTransactionsReport.Size = new System.Drawing.Size(165, 62);
            this.btnTransactionsReport.TabIndex = 9;
            this.btnTransactionsReport.Text = "Transactions Report";
            this.btnTransactionsReport.Click += new System.EventHandler(this.BtnTransactionsReport_Click);
            // 
            // btnVehicleReturnsReport
            // 
            this.btnVehicleReturnsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleReturnsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleReturnsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicleReturnsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicleReturnsReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnVehicleReturnsReport.Font = new System.Drawing.Font("Calibri", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnVehicleReturnsReport.ForeColor = System.Drawing.Color.White;
            this.btnVehicleReturnsReport.Location = new System.Drawing.Point(714, 123);
            this.btnVehicleReturnsReport.Name = "btnVehicleReturnsReport";
            this.btnVehicleReturnsReport.Size = new System.Drawing.Size(165, 62);
            this.btnVehicleReturnsReport.TabIndex = 10;
            this.btnVehicleReturnsReport.Text = "Vehicle Returns Report";
            this.btnVehicleReturnsReport.Click += new System.EventHandler(this.BtnVehicleReturnsReport_Click);
            // 
            // btnMaintenancesReport
            // 
            this.btnMaintenancesReport.BorderRadius = 22;
            this.btnMaintenancesReport.CustomizableEdges.BottomLeft = false;
            this.btnMaintenancesReport.CustomizableEdges.BottomRight = false;
            this.btnMaintenancesReport.CustomizableEdges.TopLeft = false;
            this.btnMaintenancesReport.CustomizableEdges.TopRight = false;
            this.btnMaintenancesReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenancesReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenancesReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaintenancesReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaintenancesReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnMaintenancesReport.Font = new System.Drawing.Font("Calibri", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnMaintenancesReport.ForeColor = System.Drawing.Color.White;
            this.btnMaintenancesReport.Location = new System.Drawing.Point(885, 123);
            this.btnMaintenancesReport.Name = "btnMaintenancesReport";
            this.btnMaintenancesReport.Size = new System.Drawing.Size(165, 62);
            this.btnMaintenancesReport.TabIndex = 11;
            this.btnMaintenancesReport.Text = "Maintenances Report";
            this.btnMaintenancesReport.Click += new System.EventHandler(this.BtnMaintenancesReport_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 22;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(188, 53);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(229, 59);
            this.dtpStartDate.TabIndex = 176;
            this.dtpStartDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 22;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dtpEndDate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(188, 145);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(229, 59);
            this.dtpEndDate.TabIndex = 177;
            this.dtpEndDate.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 179;
            this.label1.Text = "Start Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(67, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 180;
            this.label2.Text = "End Date :";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnGenerateReport);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.dtpStartDate);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.dtpEndDate);
            this.pnlContainer.Location = new System.Drawing.Point(273, 284);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(746, 260);
            this.pnlContainer.TabIndex = 181;
            this.pnlContainer.Visible = false;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BorderRadius = 22;
            this.btnGenerateReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnGenerateReport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Image = global::CarRentalManagementSystem.Properties.Resources.report;
            this.btnGenerateReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenerateReport.Location = new System.Drawing.Point(494, 102);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(171, 62);
            this.btnGenerateReport.TabIndex = 178;
            this.btnGenerateReport.Text = "Report";
            this.btnGenerateReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources._3d_report;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2ImageButton1.Location = new System.Drawing.Point(30, 19);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(60, 60);
            this.guna2ImageButton1.TabIndex = 4;
            // 
            // btnProfitReport
            // 
            this.btnProfitReport.BorderRadius = 22;
            this.btnProfitReport.CustomizableEdges.BottomLeft = false;
            this.btnProfitReport.CustomizableEdges.TopLeft = false;
            this.btnProfitReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfitReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfitReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfitReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfitReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnProfitReport.Font = new System.Drawing.Font("Calibri", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnProfitReport.ForeColor = System.Drawing.Color.White;
            this.btnProfitReport.Location = new System.Drawing.Point(1056, 123);
            this.btnProfitReport.Name = "btnProfitReport";
            this.btnProfitReport.Size = new System.Drawing.Size(165, 62);
            this.btnProfitReport.TabIndex = 182;
            this.btnProfitReport.Text = "Profit Report";
            this.btnProfitReport.Click += new System.EventHandler(this.BtnProfitReport_Click);
            // 
            // FrmGenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 759);
            this.Controls.Add(this.btnProfitReport);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnMaintenancesReport);
            this.Controls.Add(this.btnVehicleReturnsReport);
            this.Controls.Add(this.btnTransactionsReport);
            this.Controls.Add(this.btnRentalBookingsReport);
            this.Controls.Add(this.btnCustomersListReport);
            this.Controls.Add(this.btnVehiclesListReport);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGenerateReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGenerateReports";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnVehiclesListReport;
        private Guna.UI2.WinForms.Guna2Button btnCustomersListReport;
        private Guna.UI2.WinForms.Guna2Button btnRentalBookingsReport;
        private Guna.UI2.WinForms.Guna2Button btnTransactionsReport;
        private Guna.UI2.WinForms.Guna2Button btnVehicleReturnsReport;
        private Guna.UI2.WinForms.Guna2Button btnMaintenancesReport;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Button btnProfitReport;
    }
}
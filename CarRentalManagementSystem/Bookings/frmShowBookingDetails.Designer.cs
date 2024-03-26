namespace CarRentalManagementSystem.Bookings
{
    partial class FrmShowBookingDetails
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
            this.ucCustomerCard1 = new CarRentalManagementSystem.Customers.UserControls.UcCustomerCard();
            this.tpVehicleInfo = new System.Windows.Forms.TabPage();
            this.ucVehicleCard1 = new CarRentalManagementSystem.Vehicles.UserControls.UcVehicleCard();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucBookingDetails1 = new CarRentalManagementSystem.Bookings.UserControls.UcBookingDetails();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcRentalBooking.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tpVehicleInfo.SuspendLayout();
            this.tpBookingInfo.SuspendLayout();
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
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1033, 73);
            this.guna2GradientPanel1.TabIndex = 176;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.rental;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Location = new System.Drawing.Point(404, 9);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Size = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(457, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Booking Details";
            // 
            // tcRentalBooking
            // 
            this.tcRentalBooking.Controls.Add(this.tpCustomerInfo);
            this.tcRentalBooking.Controls.Add(this.tpVehicleInfo);
            this.tcRentalBooking.Controls.Add(this.tpBookingInfo);
            this.tcRentalBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcRentalBooking.ItemSize = new System.Drawing.Size(180, 50);
            this.tcRentalBooking.Location = new System.Drawing.Point(0, 73);
            this.tcRentalBooking.Name = "tcRentalBooking";
            this.tcRentalBooking.SelectedIndex = 0;
            this.tcRentalBooking.Size = new System.Drawing.Size(1033, 680);
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
            this.tcRentalBooking.TabIndex = 205;
            this.tcRentalBooking.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcRentalBooking.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.Controls.Add(this.ucCustomerCard1);
            this.tpCustomerInfo.Location = new System.Drawing.Point(4, 54);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomerInfo.Size = new System.Drawing.Size(1025, 622);
            this.tpCustomerInfo.TabIndex = 0;
            this.tpCustomerInfo.Text = "Customer Info";
            this.tpCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // ucCustomerCard1
            // 
            this.ucCustomerCard1.BackColor = System.Drawing.Color.White;
            this.ucCustomerCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomerCard1.Location = new System.Drawing.Point(3, 3);
            this.ucCustomerCard1.Name = "ucCustomerCard1";
            this.ucCustomerCard1.Size = new System.Drawing.Size(1019, 616);
            this.ucCustomerCard1.TabIndex = 0;
            // 
            // tpVehicleInfo
            // 
            this.tpVehicleInfo.Controls.Add(this.ucVehicleCard1);
            this.tpVehicleInfo.Location = new System.Drawing.Point(4, 54);
            this.tpVehicleInfo.Name = "tpVehicleInfo";
            this.tpVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicleInfo.Size = new System.Drawing.Size(1025, 622);
            this.tpVehicleInfo.TabIndex = 1;
            this.tpVehicleInfo.Text = "Vehicle Info";
            this.tpVehicleInfo.UseVisualStyleBackColor = true;
            // 
            // ucVehicleCard1
            // 
            this.ucVehicleCard1.BackColor = System.Drawing.Color.White;
            this.ucVehicleCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVehicleCard1.Location = new System.Drawing.Point(3, 3);
            this.ucVehicleCard1.Name = "ucVehicleCard1";
            this.ucVehicleCard1.Size = new System.Drawing.Size(1019, 616);
            this.ucVehicleCard1.TabIndex = 0;
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.Controls.Add(this.ucBookingDetails1);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 54);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingInfo.Size = new System.Drawing.Size(1025, 622);
            this.tpBookingInfo.TabIndex = 2;
            this.tpBookingInfo.Text = "Booking Info";
            this.tpBookingInfo.UseVisualStyleBackColor = true;
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
            this.btnClose.Location = new System.Drawing.Point(857, 757);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 58);
            this.btnClose.TabIndex = 206;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ucBookingDetails1
            // 
            this.ucBookingDetails1.BackColor = System.Drawing.Color.White;
            this.ucBookingDetails1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBookingDetails1.Location = new System.Drawing.Point(3, 3);
            this.ucBookingDetails1.Name = "ucBookingDetails1";
            this.ucBookingDetails1.Size = new System.Drawing.Size(1019, 508);
            this.ucBookingDetails1.TabIndex = 0;
            // 
            // frmShowBookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 830);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcRentalBooking);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowBookingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowBookingDetails";
            this.Load += new System.EventHandler(this.FrmShowBookingDetails_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcRentalBooking.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpVehicleInfo.ResumeLayout(false);
            this.tpBookingInfo.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tpBookingInfo;
        private Customers.UserControls.UcCustomerCard ucCustomerCard1;
        private Vehicles.UserControls.UcVehicleCard ucVehicleCard1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private UserControls.UcBookingDetails ucBookingDetails1;
    }
}
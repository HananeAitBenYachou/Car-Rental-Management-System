﻿namespace CarRentalManagementSystem
{
    partial class frmHome
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
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageReturns = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageBookings = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnCollapse = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 75;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.btnLogout);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnManageUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnManageCustomers);
            this.guna2GradientPanel1.Controls.Add(this.btnManageTransactions);
            this.guna2GradientPanel1.Controls.Add(this.btnManageReturns);
            this.guna2GradientPanel1.Controls.Add(this.btnManageBookings);
            this.guna2GradientPanel1.Controls.Add(this.btnManageVehicles);
            this.guna2GradientPanel1.Controls.Add(this.btnDashboard);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.CustomizableEdges.BottomLeft = false;
            this.guna2GradientPanel1.CustomizableEdges.BottomRight = false;
            this.guna2GradientPanel1.CustomizableEdges.TopLeft = false;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 59);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(290, 949);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 23;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnLogout.Image = global::CarRentalManagementSystem.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnLogout.ImageSize = new System.Drawing.Size(32, 32);
            this.btnLogout.Location = new System.Drawing.Point(45, 554);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 55);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(8, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CarRentalManagementSystem.Properties.Resources.Car_rental_bro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 590);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.BorderRadius = 23;
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnManageUsers.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnManageUsers.Image = global::CarRentalManagementSystem.Properties.Resources.client;
            this.btnManageUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.ImageOffset = new System.Drawing.Point(-5, -2);
            this.btnManageUsers.ImageSize = new System.Drawing.Size(38, 38);
            this.btnManageUsers.Location = new System.Drawing.Point(45, 497);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(210, 55);
            this.btnManageUsers.TabIndex = 7;
            this.btnManageUsers.Text = "Users";
            this.btnManageUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.TextOffset = new System.Drawing.Point(8, 0);
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnManageCustomers.BorderRadius = 23;
            this.btnManageCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnManageCustomers.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnManageCustomers.Image = global::CarRentalManagementSystem.Properties.Resources.team;
            this.btnManageCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageCustomers.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnManageCustomers.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManageCustomers.Location = new System.Drawing.Point(45, 434);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(210, 55);
            this.btnManageCustomers.TabIndex = 6;
            this.btnManageCustomers.Text = "Customers";
            this.btnManageCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageCustomers.TextOffset = new System.Drawing.Point(8, -1);
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageTransactions
            // 
            this.btnManageTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnManageTransactions.BorderRadius = 23;
            this.btnManageTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageTransactions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnManageTransactions.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnManageTransactions.Image = global::CarRentalManagementSystem.Properties.Resources.transaction;
            this.btnManageTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageTransactions.ImageOffset = new System.Drawing.Point(-5, -3);
            this.btnManageTransactions.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManageTransactions.Location = new System.Drawing.Point(45, 376);
            this.btnManageTransactions.Name = "btnManageTransactions";
            this.btnManageTransactions.Size = new System.Drawing.Size(210, 55);
            this.btnManageTransactions.TabIndex = 5;
            this.btnManageTransactions.Text = "Transactions";
            this.btnManageTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageTransactions.TextOffset = new System.Drawing.Point(8, -3);
            // 
            // btnManageReturns
            // 
            this.btnManageReturns.BackColor = System.Drawing.Color.Transparent;
            this.btnManageReturns.BorderRadius = 23;
            this.btnManageReturns.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageReturns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageReturns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageReturns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageReturns.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnManageReturns.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageReturns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnManageReturns.Image = global::CarRentalManagementSystem.Properties.Resources.car_key;
            this.btnManageReturns.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageReturns.ImageOffset = new System.Drawing.Point(-5, -3);
            this.btnManageReturns.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManageReturns.Location = new System.Drawing.Point(45, 315);
            this.btnManageReturns.Name = "btnManageReturns";
            this.btnManageReturns.Size = new System.Drawing.Size(210, 55);
            this.btnManageReturns.TabIndex = 4;
            this.btnManageReturns.Text = "Returns";
            this.btnManageReturns.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageReturns.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.BackColor = System.Drawing.Color.Transparent;
            this.btnManageBookings.BorderRadius = 23;
            this.btnManageBookings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageBookings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageBookings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageBookings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageBookings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnManageBookings.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnManageBookings.Image = global::CarRentalManagementSystem.Properties.Resources.car_rental;
            this.btnManageBookings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageBookings.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnManageBookings.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManageBookings.Location = new System.Drawing.Point(45, 253);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(210, 55);
            this.btnManageBookings.TabIndex = 3;
            this.btnManageBookings.Text = "Bookings";
            this.btnManageBookings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageBookings.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnManageVehicles
            // 
            this.btnManageVehicles.BackColor = System.Drawing.Color.Transparent;
            this.btnManageVehicles.BorderRadius = 23;
            this.btnManageVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageVehicles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnManageVehicles.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnManageVehicles.Image = global::CarRentalManagementSystem.Properties.Resources.fast_delivery;
            this.btnManageVehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageVehicles.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnManageVehicles.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManageVehicles.Location = new System.Drawing.Point(45, 201);
            this.btnManageVehicles.Name = "btnManageVehicles";
            this.btnManageVehicles.Size = new System.Drawing.Size(210, 55);
            this.btnManageVehicles.TabIndex = 2;
            this.btnManageVehicles.Text = "Vehicles";
            this.btnManageVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageVehicles.TextOffset = new System.Drawing.Point(8, -6);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 23;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.btnDashboard.Image = global::CarRentalManagementSystem.Properties.Resources.home;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(-5, -2);
            this.btnDashboard.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDashboard.Location = new System.Drawing.Point(45, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 55);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(8, -1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CarRentalManagementSystem.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, -6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 156);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(310, 116);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1263, 759);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnCollapse.CheckedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCollapse.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCollapse.Image = global::CarRentalManagementSystem.Properties.Resources.minus_button;
            this.btnCollapse.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCollapse.ImageRotate = 0F;
            this.btnCollapse.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCollapse.Location = new System.Drawing.Point(1486, 7);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCollapse.ShadowDecoration.BorderRadius = 0;
            this.btnCollapse.Size = new System.Drawing.Size(44, 37);
            this.btnCollapse.TabIndex = 3;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            this.btnCollapse.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCollapse.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnExit.Image = global::CarRentalManagementSystem.Properties.Resources.cross;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnExit.Location = new System.Drawing.Point(1542, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnExit.ShadowDecoration.BorderRadius = 0;
            this.btnExit.Size = new System.Drawing.Size(44, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1595, 949);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnManageReturns;
        private Guna.UI2.WinForms.Guna2Button btnManageBookings;
        private Guna.UI2.WinForms.Guna2Button btnManageVehicles;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private Guna.UI2.WinForms.Guna2Button btnManageCustomers;
        private Guna.UI2.WinForms.Guna2Button btnManageTransactions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ImageButton btnCollapse;
    }
}
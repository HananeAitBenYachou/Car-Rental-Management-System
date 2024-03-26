namespace CarRentalManagementSystem.Returns
{
    partial class FrmShowVehicleReturnDetails
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
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.tcVehicleReturn = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.tpVehicleInfo = new System.Windows.Forms.TabPage();
            this.tpVehicleReturnInfo = new System.Windows.Forms.TabPage();
            this.ucCustomerCard1 = new CarRentalManagementSystem.Customers.UserControls.UcCustomerCard();
            this.ucVehicleCard1 = new CarRentalManagementSystem.Vehicles.UserControls.UcVehicleCard();
            this.ucVehicleReturnDetails1 = new CarRentalManagementSystem.Returns.UserControls.UcVehicleReturnDetails();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcVehicleReturn.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tpVehicleInfo.SuspendLayout();
            this.tpVehicleReturnInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2GradientPanel1.TabIndex = 177;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.rental1;
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
            this.lblTitle.Size = new System.Drawing.Size(149, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Return Details";
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
            this.btnClose.TabIndex = 208;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tcVehicleReturn
            // 
            this.tcVehicleReturn.Controls.Add(this.tpCustomerInfo);
            this.tcVehicleReturn.Controls.Add(this.tpVehicleInfo);
            this.tcVehicleReturn.Controls.Add(this.tpVehicleReturnInfo);
            this.tcVehicleReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcVehicleReturn.ItemSize = new System.Drawing.Size(180, 50);
            this.tcVehicleReturn.Location = new System.Drawing.Point(0, 73);
            this.tcVehicleReturn.Name = "tcVehicleReturn";
            this.tcVehicleReturn.SelectedIndex = 0;
            this.tcVehicleReturn.Size = new System.Drawing.Size(1033, 680);
            this.tcVehicleReturn.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcVehicleReturn.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcVehicleReturn.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcVehicleReturn.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcVehicleReturn.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcVehicleReturn.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcVehicleReturn.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcVehicleReturn.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcVehicleReturn.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcVehicleReturn.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcVehicleReturn.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcVehicleReturn.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcVehicleReturn.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcVehicleReturn.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcVehicleReturn.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.tcVehicleReturn.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcVehicleReturn.TabIndex = 207;
            this.tcVehicleReturn.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcVehicleReturn.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
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
            // tpVehicleReturnInfo
            // 
            this.tpVehicleReturnInfo.Controls.Add(this.ucVehicleReturnDetails1);
            this.tpVehicleReturnInfo.Location = new System.Drawing.Point(4, 54);
            this.tpVehicleReturnInfo.Name = "tpVehicleReturnInfo";
            this.tpVehicleReturnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicleReturnInfo.Size = new System.Drawing.Size(1025, 622);
            this.tpVehicleReturnInfo.TabIndex = 2;
            this.tpVehicleReturnInfo.Text = "Return Info";
            this.tpVehicleReturnInfo.UseVisualStyleBackColor = true;
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
            // ucVehicleCard1
            // 
            this.ucVehicleCard1.BackColor = System.Drawing.Color.White;
            this.ucVehicleCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVehicleCard1.Location = new System.Drawing.Point(3, 3);
            this.ucVehicleCard1.Name = "ucVehicleCard1";
            this.ucVehicleCard1.Size = new System.Drawing.Size(1019, 616);
            this.ucVehicleCard1.TabIndex = 0;
            // 
            // ucVehicleReturnDetails1
            // 
            this.ucVehicleReturnDetails1.BackColor = System.Drawing.Color.White;
            this.ucVehicleReturnDetails1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucVehicleReturnDetails1.Location = new System.Drawing.Point(3, 3);
            this.ucVehicleReturnDetails1.Name = "ucVehicleReturnDetails1";
            this.ucVehicleReturnDetails1.Size = new System.Drawing.Size(1019, 434);
            this.ucVehicleReturnDetails1.TabIndex = 0;
            // 
            // frmShowVehicleReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 822);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcVehicleReturn);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowVehicleReturnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowVehicleReturnDetails";
            this.Load += new System.EventHandler(this.FrmShowVehicleReturnDetails_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcVehicleReturn.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpVehicleInfo.ResumeLayout(false);
            this.tpVehicleReturnInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TabControl tcVehicleReturn;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private Customers.UserControls.UcCustomerCard ucCustomerCard1;
        private System.Windows.Forms.TabPage tpVehicleInfo;
        private Vehicles.UserControls.UcVehicleCard ucVehicleCard1;
        private System.Windows.Forms.TabPage tpVehicleReturnInfo;
        private UserControls.UcVehicleReturnDetails ucVehicleReturnDetails1;
    }
}
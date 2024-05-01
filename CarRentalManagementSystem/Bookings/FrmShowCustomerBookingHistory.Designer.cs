namespace CarRentalManagementSystem.Bookings
{
    partial class FrmShowCustomerBookingHistory
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ucCustomerCard1 = new CarRentalManagementSystem.Customers.UserControls.UcCustomerCard();
            this.tcBookingHistory = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookingHistory = new System.Windows.Forms.TabPage();
            this.dgvBookingsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbRentalBookings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showBookingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcBookingHistory.SuspendLayout();
            this.tpBookingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingsList)).BeginInit();
            this.cbRentalBookings.SuspendLayout();
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1018, 73);
            this.guna2GradientPanel1.TabIndex = 179;
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(329, 9);
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
            this.lblTitle.Location = new System.Drawing.Point(382, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Customer Booking History";
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
            this.btnClose.Location = new System.Drawing.Point(843, 1036);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 58);
            this.btnClose.TabIndex = 212;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ucCustomerCard1
            // 
            this.ucCustomerCard1.BackColor = System.Drawing.Color.White;
            this.ucCustomerCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCustomerCard1.Location = new System.Drawing.Point(0, 73);
            this.ucCustomerCard1.Name = "ucCustomerCard1";
            this.ucCustomerCard1.Size = new System.Drawing.Size(1018, 617);
            this.ucCustomerCard1.TabIndex = 213;
            // 
            // tcBookingHistory
            // 
            this.tcBookingHistory.Controls.Add(this.tpBookingHistory);
            this.tcBookingHistory.ItemSize = new System.Drawing.Size(180, 50);
            this.tcBookingHistory.Location = new System.Drawing.Point(0, 704);
            this.tcBookingHistory.Name = "tcBookingHistory";
            this.tcBookingHistory.SelectedIndex = 0;
            this.tcBookingHistory.Size = new System.Drawing.Size(1018, 332);
            this.tcBookingHistory.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcBookingHistory.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcBookingHistory.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBookingHistory.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcBookingHistory.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcBookingHistory.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcBookingHistory.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcBookingHistory.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBookingHistory.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcBookingHistory.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcBookingHistory.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcBookingHistory.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcBookingHistory.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBookingHistory.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcBookingHistory.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.tcBookingHistory.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcBookingHistory.TabIndex = 214;
            this.tcBookingHistory.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcBookingHistory.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookingHistory
            // 
            this.tpBookingHistory.Controls.Add(this.dgvBookingsList);
            this.tpBookingHistory.Location = new System.Drawing.Point(4, 54);
            this.tpBookingHistory.Name = "tpBookingHistory";
            this.tpBookingHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingHistory.Size = new System.Drawing.Size(1010, 274);
            this.tpBookingHistory.TabIndex = 2;
            this.tpBookingHistory.Text = "Booking History";
            this.tpBookingHistory.UseVisualStyleBackColor = true;
            // 
            // dgvBookingsList
            // 
            this.dgvBookingsList.AllowUserToAddRows = false;
            this.dgvBookingsList.AllowUserToDeleteRows = false;
            this.dgvBookingsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvBookingsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookingsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBookingsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookingsList.ColumnHeadersHeight = 45;
            this.dgvBookingsList.ContextMenuStrip = this.cbRentalBookings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookingsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookingsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvBookingsList.Location = new System.Drawing.Point(3, 3);
            this.dgvBookingsList.MultiSelect = false;
            this.dgvBookingsList.Name = "dgvBookingsList";
            this.dgvBookingsList.ReadOnly = true;
            this.dgvBookingsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookingsList.RowHeadersVisible = false;
            this.dgvBookingsList.RowHeadersWidth = 51;
            this.dgvBookingsList.RowTemplate.Height = 50;
            this.dgvBookingsList.Size = new System.Drawing.Size(1004, 268);
            this.dgvBookingsList.TabIndex = 207;
            this.dgvBookingsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.dgvBookingsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvBookingsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBookingsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBookingsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBookingsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBookingsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookingsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvBookingsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.dgvBookingsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBookingsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvBookingsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBookingsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookingsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvBookingsList.ThemeStyle.ReadOnly = true;
            this.dgvBookingsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.dgvBookingsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvBookingsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvBookingsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvBookingsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvBookingsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.dgvBookingsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvBookingsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookingsList_CellContentDoubleClick);
            this.dgvBookingsList.SelectionChanged += new System.EventHandler(this.DgvBookingsList_SelectionChanged);
            // 
            // cbRentalBookings
            // 
            this.cbRentalBookings.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbRentalBookings.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cbRentalBookings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookingInformationToolStripMenuItem,
            this.returnVehicleToolStripMenuItem});
            this.cbRentalBookings.Name = "cbUsers";
            this.cbRentalBookings.Size = new System.Drawing.Size(283, 76);
            this.cbRentalBookings.Opening += new System.ComponentModel.CancelEventHandler(this.CbRentalBookings_Opening);
            // 
            // showBookingInformationToolStripMenuItem
            // 
            this.showBookingInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showBookingInformationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.showBookingInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showBookingInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.eye;
            this.showBookingInformationToolStripMenuItem.Name = "showBookingInformationToolStripMenuItem";
            this.showBookingInformationToolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.showBookingInformationToolStripMenuItem.Text = "Show Booking Information";
            this.showBookingInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowBookingInformationToolStripMenuItem_Click);
            // 
            // returnVehicleToolStripMenuItem
            // 
            this.returnVehicleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.returnVehicleToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.returnVehicleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnVehicleToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.return1;
            this.returnVehicleToolStripMenuItem.Name = "returnVehicleToolStripMenuItem";
            this.returnVehicleToolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.returnVehicleToolStripMenuItem.Text = "Return Vehicle";
            this.returnVehicleToolStripMenuItem.Click += new System.EventHandler(this.ReturnVehicleToolStripMenuItem_Click);
            // 
            // FrmShowCustomerBookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 1000);
            this.Controls.Add(this.tcBookingHistory);
            this.Controls.Add(this.ucCustomerCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShowCustomerBookingHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowCustomerBookingHistory";
            this.Load += new System.EventHandler(this.FrmShowCustomerBookingHistory_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcBookingHistory.ResumeLayout(false);
            this.tpBookingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingsList)).EndInit();
            this.cbRentalBookings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Customers.UserControls.UcCustomerCard ucCustomerCard1;
        private Guna.UI2.WinForms.Guna2TabControl tcBookingHistory;
        private System.Windows.Forms.TabPage tpBookingHistory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBookingsList;
        private System.Windows.Forms.ContextMenuStrip cbRentalBookings;
        private System.Windows.Forms.ToolStripMenuItem showBookingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnVehicleToolStripMenuItem;
    }
}
namespace CarRentalManagementSystem.Transactions
{
    partial class FrmShowCustomerTransactionHistory
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
            this.tcTransactionHistory = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpTransactionHistory = new System.Windows.Forms.TabPage();
            this.dgvTransactionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbRentalTransactions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTransactionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showBookingInforamtionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReturnInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucCustomerCard1 = new CarRentalManagementSystem.Customers.UserControls.UcCustomerCard();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcTransactionHistory.SuspendLayout();
            this.tpTransactionHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).BeginInit();
            this.cbRentalTransactions.SuspendLayout();
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
            this.guna2GradientPanel1.TabIndex = 180;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.transaction__1_;
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
            this.lblTitle.Size = new System.Drawing.Size(290, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Customer Transaction History";
            // 
            // tcTransactionHistory
            // 
            this.tcTransactionHistory.Controls.Add(this.tpTransactionHistory);
            this.tcTransactionHistory.ItemSize = new System.Drawing.Size(180, 50);
            this.tcTransactionHistory.Location = new System.Drawing.Point(0, 700);
            this.tcTransactionHistory.Name = "tcTransactionHistory";
            this.tcTransactionHistory.SelectedIndex = 0;
            this.tcTransactionHistory.Size = new System.Drawing.Size(1018, 332);
            this.tcTransactionHistory.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcTransactionHistory.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcTransactionHistory.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTransactionHistory.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcTransactionHistory.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcTransactionHistory.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcTransactionHistory.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcTransactionHistory.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTransactionHistory.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcTransactionHistory.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcTransactionHistory.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcTransactionHistory.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcTransactionHistory.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTransactionHistory.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcTransactionHistory.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.tcTransactionHistory.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcTransactionHistory.TabIndex = 216;
            this.tcTransactionHistory.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcTransactionHistory.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpTransactionHistory
            // 
            this.tpTransactionHistory.Controls.Add(this.dgvTransactionsList);
            this.tpTransactionHistory.Location = new System.Drawing.Point(4, 54);
            this.tpTransactionHistory.Name = "tpTransactionHistory";
            this.tpTransactionHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransactionHistory.Size = new System.Drawing.Size(1010, 274);
            this.tpTransactionHistory.TabIndex = 2;
            this.tpTransactionHistory.Text = "Transaction History";
            this.tpTransactionHistory.UseVisualStyleBackColor = true;
            // 
            // dgvTransactionsList
            // 
            this.dgvTransactionsList.AllowUserToAddRows = false;
            this.dgvTransactionsList.AllowUserToDeleteRows = false;
            this.dgvTransactionsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvTransactionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactionsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvTransactionsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactionsList.ColumnHeadersHeight = 45;
            this.dgvTransactionsList.ContextMenuStrip = this.cbRentalTransactions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvTransactionsList.Location = new System.Drawing.Point(3, 3);
            this.dgvTransactionsList.MultiSelect = false;
            this.dgvTransactionsList.Name = "dgvTransactionsList";
            this.dgvTransactionsList.ReadOnly = true;
            this.dgvTransactionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransactionsList.RowHeadersVisible = false;
            this.dgvTransactionsList.RowHeadersWidth = 51;
            this.dgvTransactionsList.RowTemplate.Height = 50;
            this.dgvTransactionsList.Size = new System.Drawing.Size(1004, 268);
            this.dgvTransactionsList.TabIndex = 207;
            this.dgvTransactionsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactionsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactionsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvTransactionsList.ThemeStyle.ReadOnly = true;
            this.dgvTransactionsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.dgvTransactionsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvTransactionsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTransactionsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvTransactionsList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvTransactionsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.dgvTransactionsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvTransactionsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTransactionsList_CellContentClick);
            this.dgvTransactionsList.SelectionChanged += new System.EventHandler(this.DgvTransactionsList_SelectionChanged);
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
            this.btnClose.Location = new System.Drawing.Point(843, 1033);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 58);
            this.btnClose.TabIndex = 215;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // cbRentalTransactions
            // 
            this.cbRentalTransactions.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.cbRentalTransactions.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cbRentalTransactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTransactionInformationToolStripMenuItem,
            this.showVehicleInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.showBookingInforamtionToolStripMenuItem,
            this.showReturnInformationToolStripMenuItem});
            this.cbRentalTransactions.Name = "cbUsers";
            this.cbRentalTransactions.Size = new System.Drawing.Size(334, 178);
            // 
            // showTransactionInformationToolStripMenuItem
            // 
            this.showTransactionInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showTransactionInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showTransactionInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.transaction1;
            this.showTransactionInformationToolStripMenuItem.Name = "showTransactionInformationToolStripMenuItem";
            this.showTransactionInformationToolStripMenuItem.Size = new System.Drawing.Size(333, 42);
            this.showTransactionInformationToolStripMenuItem.Text = "Show Transaction Information";
            this.showTransactionInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowTransactionInformationToolStripMenuItem_Click);
            // 
            // showVehicleInformationToolStripMenuItem
            // 
            this.showVehicleInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showVehicleInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showVehicleInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources._3d_car;
            this.showVehicleInformationToolStripMenuItem.Name = "showVehicleInformationToolStripMenuItem";
            this.showVehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(333, 42);
            this.showVehicleInformationToolStripMenuItem.Text = "Show Vehicle Information";
            this.showVehicleInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowVehicleInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(330, 6);
            // 
            // showBookingInforamtionToolStripMenuItem
            // 
            this.showBookingInforamtionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showBookingInforamtionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showBookingInforamtionToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources._event;
            this.showBookingInforamtionToolStripMenuItem.Name = "showBookingInforamtionToolStripMenuItem";
            this.showBookingInforamtionToolStripMenuItem.Size = new System.Drawing.Size(333, 42);
            this.showBookingInforamtionToolStripMenuItem.Text = "Show Booking Inforamtion";
            this.showBookingInforamtionToolStripMenuItem.Click += new System.EventHandler(this.ShowBookingInforamtionToolStripMenuItem_Click);
            // 
            // showReturnInformationToolStripMenuItem
            // 
            this.showReturnInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showReturnInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showReturnInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources._return;
            this.showReturnInformationToolStripMenuItem.Name = "showReturnInformationToolStripMenuItem";
            this.showReturnInformationToolStripMenuItem.Size = new System.Drawing.Size(333, 42);
            this.showReturnInformationToolStripMenuItem.Text = "Show Return Information";
            this.showReturnInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowReturnInformationToolStripMenuItem_Click);
            // 
            // ucCustomerCard1
            // 
            this.ucCustomerCard1.BackColor = System.Drawing.Color.White;
            this.ucCustomerCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCustomerCard1.Location = new System.Drawing.Point(0, 73);
            this.ucCustomerCard1.Name = "ucCustomerCard1";
            this.ucCustomerCard1.Size = new System.Drawing.Size(1018, 617);
            this.ucCustomerCard1.TabIndex = 218;
            // 
            // FrmShowCustomerTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 850);
            this.Controls.Add(this.ucCustomerCard1);
            this.Controls.Add(this.tcTransactionHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShowCustomerTransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowCustomerTransactionHistory";
            this.Load += new System.EventHandler(this.FrmShowCustomerTransactionHistory_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcTransactionHistory.ResumeLayout(false);
            this.tpTransactionHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).EndInit();
            this.cbRentalTransactions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcTransactionHistory;
        private System.Windows.Forms.TabPage tpTransactionHistory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactionsList;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cbRentalTransactions;
        private System.Windows.Forms.ToolStripMenuItem showTransactionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVehicleInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showBookingInforamtionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showReturnInformationToolStripMenuItem;
        private Customers.UserControls.UcCustomerCard ucCustomerCard1;
    }
}
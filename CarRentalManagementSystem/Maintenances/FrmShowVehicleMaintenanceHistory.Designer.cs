namespace CarRentalManagementSystem.Maintenances
{
    partial class FrmShowVehicleMaintenanceHistory
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
            this.ucVehicleCard1 = new CarRentalManagementSystem.Vehicles.UserControls.UcVehicleCard();
            this.tcMaintenanceHistory = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMaintenanceHistory = new System.Windows.Forms.TabPage();
            this.dgvMaintenancesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.tcMaintenanceHistory.SuspendLayout();
            this.tpMaintenanceHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenancesList)).BeginInit();
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(963, 73);
            this.guna2GradientPanel1.TabIndex = 177;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.car_repair;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Location = new System.Drawing.Point(353, 9);
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
            this.lblTitle.Location = new System.Drawing.Point(406, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Maintenance History";
            // 
            // ucVehicleCard1
            // 
            this.ucVehicleCard1.BackColor = System.Drawing.Color.White;
            this.ucVehicleCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucVehicleCard1.Location = new System.Drawing.Point(0, 73);
            this.ucVehicleCard1.Name = "ucVehicleCard1";
            this.ucVehicleCard1.Size = new System.Drawing.Size(963, 522);
            this.ucVehicleCard1.TabIndex = 178;
            // 
            // tcMaintenanceHistory
            // 
            this.tcMaintenanceHistory.Controls.Add(this.tpMaintenanceHistory);
            this.tcMaintenanceHistory.ItemSize = new System.Drawing.Size(180, 50);
            this.tcMaintenanceHistory.Location = new System.Drawing.Point(0, 603);
            this.tcMaintenanceHistory.Name = "tcMaintenanceHistory";
            this.tcMaintenanceHistory.SelectedIndex = 0;
            this.tcMaintenanceHistory.Size = new System.Drawing.Size(963, 332);
            this.tcMaintenanceHistory.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintenanceHistory.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintenanceHistory.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintenanceHistory.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMaintenanceHistory.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintenanceHistory.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintenanceHistory.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintenanceHistory.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintenanceHistory.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcMaintenanceHistory.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintenanceHistory.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcMaintenanceHistory.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintenanceHistory.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMaintenanceHistory.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMaintenanceHistory.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.tcMaintenanceHistory.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcMaintenanceHistory.TabIndex = 207;
            this.tcMaintenanceHistory.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.tcMaintenanceHistory.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpMaintenanceHistory
            // 
            this.tpMaintenanceHistory.Controls.Add(this.dgvMaintenancesList);
            this.tpMaintenanceHistory.Location = new System.Drawing.Point(4, 54);
            this.tpMaintenanceHistory.Name = "tpMaintenanceHistory";
            this.tpMaintenanceHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaintenanceHistory.Size = new System.Drawing.Size(955, 274);
            this.tpMaintenanceHistory.TabIndex = 2;
            this.tpMaintenanceHistory.Text = "Maintenance History";
            this.tpMaintenanceHistory.UseVisualStyleBackColor = true;
            // 
            // dgvMaintenancesList
            // 
            this.dgvMaintenancesList.AllowUserToAddRows = false;
            this.dgvMaintenancesList.AllowUserToDeleteRows = false;
            this.dgvMaintenancesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvMaintenancesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaintenancesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMaintenancesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenancesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaintenancesList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaintenancesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaintenancesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaintenancesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvMaintenancesList.Location = new System.Drawing.Point(3, 3);
            this.dgvMaintenancesList.MultiSelect = false;
            this.dgvMaintenancesList.Name = "dgvMaintenancesList";
            this.dgvMaintenancesList.ReadOnly = true;
            this.dgvMaintenancesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenancesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaintenancesList.RowHeadersVisible = false;
            this.dgvMaintenancesList.RowHeadersWidth = 51;
            this.dgvMaintenancesList.RowTemplate.Height = 50;
            this.dgvMaintenancesList.Size = new System.Drawing.Size(949, 268);
            this.dgvMaintenancesList.TabIndex = 207;
            this.dgvMaintenancesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.dgvMaintenancesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvMaintenancesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMaintenancesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMaintenancesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMaintenancesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMaintenancesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaintenancesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvMaintenancesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.dgvMaintenancesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMaintenancesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMaintenancesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMaintenancesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaintenancesList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvMaintenancesList.ThemeStyle.ReadOnly = true;
            this.dgvMaintenancesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.dgvMaintenancesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvMaintenancesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMaintenancesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.dgvMaintenancesList.ThemeStyle.RowsStyle.Height = 50;
            this.dgvMaintenancesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.dgvMaintenancesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
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
            this.btnClose.Location = new System.Drawing.Point(785, 936);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 58);
            this.btnClose.TabIndex = 208;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmShowVehicleMaintenanceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 1000);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcMaintenanceHistory);
            this.Controls.Add(this.ucVehicleCard1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShowVehicleMaintenanceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowVehicleMaintenancesHistory";
            this.Load += new System.EventHandler(this.FrmShowVehicleMaintenancesHistory_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tcMaintenanceHistory.ResumeLayout(false);
            this.tpMaintenanceHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenancesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblTitle;
        private Vehicles.UserControls.UcVehicleCard ucVehicleCard1;
        private Guna.UI2.WinForms.Guna2TabControl tcMaintenanceHistory;
        private System.Windows.Forms.TabPage tpMaintenanceHistory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMaintenancesList;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
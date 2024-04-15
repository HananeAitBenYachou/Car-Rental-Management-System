namespace CarRentalManagementSystem.Transactions
{
    partial class FrmListTransactions
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
            this.dgvTransactionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbRentalTransactions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTransactionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showBookingInforamtionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReturnInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dtpTemp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).BeginInit();
            this.cbRentalTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransactionsList
            // 
            this.dgvTransactionsList.AllowUserToAddRows = false;
            this.dgvTransactionsList.AllowUserToDeleteRows = false;
            this.dgvTransactionsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.dgvTransactionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.dgvTransactionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.dgvTransactionsList.Location = new System.Drawing.Point(28, 275);
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
            this.dgvTransactionsList.Size = new System.Drawing.Size(1185, 437);
            this.dgvTransactionsList.TabIndex = 23;
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
            this.dgvTransactionsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTransactionsList_CellContentDoubleClick);
            this.dgvTransactionsList.SelectionChanged += new System.EventHandler(this.DgvTransactionsList_SelectionChanged);
            // 
            // cbRentalTransactions
            // 
            this.cbRentalTransactions.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cbRentalTransactions.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cbRentalTransactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTransactionInformationToolStripMenuItem,
            this.showCustomerInformationToolStripMenuItem,
            this.showVehicleInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.showBookingInforamtionToolStripMenuItem,
            this.showReturnInformationToolStripMenuItem});
            this.cbRentalTransactions.Name = "cbUsers";
            this.cbRentalTransactions.Size = new System.Drawing.Size(311, 248);
            this.cbRentalTransactions.Opening += new System.ComponentModel.CancelEventHandler(this.CbRentalTransactions_Opening);
            // 
            // showTransactionInformationToolStripMenuItem
            // 
            this.showTransactionInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showTransactionInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showTransactionInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.transaction1;
            this.showTransactionInformationToolStripMenuItem.Name = "showTransactionInformationToolStripMenuItem";
            this.showTransactionInformationToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.showTransactionInformationToolStripMenuItem.Text = "Show Transaction Information";
            this.showTransactionInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowTransactionInformationToolStripMenuItem_Click);
            // 
            // showCustomerInformationToolStripMenuItem
            // 
            this.showCustomerInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showCustomerInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showCustomerInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources.networking;
            this.showCustomerInformationToolStripMenuItem.Name = "showCustomerInformationToolStripMenuItem";
            this.showCustomerInformationToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.showCustomerInformationToolStripMenuItem.Text = "Show Customer Information";
            this.showCustomerInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowCustomerInformationToolStripMenuItem_Click);
            // 
            // showVehicleInformationToolStripMenuItem
            // 
            this.showVehicleInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showVehicleInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showVehicleInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources._3d_car;
            this.showVehicleInformationToolStripMenuItem.Name = "showVehicleInformationToolStripMenuItem";
            this.showVehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.showVehicleInformationToolStripMenuItem.Text = "Show Vehicle Information";
            this.showVehicleInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowVehicleInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(307, 6);
            // 
            // showBookingInforamtionToolStripMenuItem
            // 
            this.showBookingInforamtionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showBookingInforamtionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showBookingInforamtionToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources._event;
            this.showBookingInforamtionToolStripMenuItem.Name = "showBookingInforamtionToolStripMenuItem";
            this.showBookingInforamtionToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.showBookingInforamtionToolStripMenuItem.Text = "Show Booking Inforamtion";
            this.showBookingInforamtionToolStripMenuItem.Click += new System.EventHandler(this.ShowBookingInforamtionToolStripMenuItem_Click);
            // 
            // showReturnInformationToolStripMenuItem
            // 
            this.showReturnInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.showReturnInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showReturnInformationToolStripMenuItem.Image = global::CarRentalManagementSystem.Properties.Resources._return;
            this.showReturnInformationToolStripMenuItem.Name = "showReturnInformationToolStripMenuItem";
            this.showReturnInformationToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.showReturnInformationToolStripMenuItem.Text = "Show Return Information";
            this.showReturnInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowReturnInformationToolStripMenuItem_Click);
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByOptions.BorderRadius = 22;
            this.cbFilterByOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbFilterByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByOptions.ItemHeight = 35;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "None",
            "Transaction ID",
            "Booking ID",
            "Customer ID",
            "Customer Name",
            "Return ID",
            "Transaction Date",
            "Updated Transaction Date"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(115, 208);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByOptions.TabIndex = 22;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filter by :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(30, 81);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1188, 10);
            this.guna2Separator1.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.lblTitle.Location = new System.Drawing.Point(92, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 31);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Manage Rental Transactions";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 22;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.IconRight = global::CarRentalManagementSystem.Properties.Resources.search;
            this.txtFilterValue.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtFilterValue.Location = new System.Drawing.Point(337, 206);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 43);
            this.txtFilterValue.TabIndex = 21;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.TxtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::CarRentalManagementSystem.Properties.Resources.transaction1;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(24, 11);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 18;
            // 
            // dtpTemp
            // 
            this.dtpTemp.BorderRadius = 22;
            this.dtpTemp.Checked = true;
            this.dtpTemp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.dtpTemp.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTemp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTemp.Location = new System.Drawing.Point(337, 206);
            this.dtpTemp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTemp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTemp.Name = "dtpTemp";
            this.dtpTemp.Size = new System.Drawing.Size(229, 43);
            this.dtpTemp.TabIndex = 24;
            this.dtpTemp.Value = new System.DateTime(2024, 3, 2, 0, 28, 59, 414);
            this.dtpTemp.ValueChanged += new System.EventHandler(this.DtpTemp_ValueChanged);
            // 
            // FrmListTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 759);
            this.Controls.Add(this.dtpTemp);
            this.Controls.Add(this.dgvTransactionsList);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListTransactions";
            this.Load += new System.EventHandler(this.FrmListTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).EndInit();
            this.cbRentalTransactions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactionsList;
        private System.Windows.Forms.ContextMenuStrip cbRentalTransactions;
        private System.Windows.Forms.ToolStripMenuItem showTransactionInformationToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTemp;
        private System.Windows.Forms.ToolStripMenuItem showCustomerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVehicleInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showBookingInforamtionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showReturnInformationToolStripMenuItem;
    }
}
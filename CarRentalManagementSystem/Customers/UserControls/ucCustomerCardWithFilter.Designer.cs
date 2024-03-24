namespace CarRentalManagementSystem.Customers.UserControls
{
    partial class UcCustomerCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearchCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucCustomerCard1 = new CarRentalManagementSystem.Customers.UserControls.UcCustomerCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.Silver;
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.btnAddCustomer);
            this.gbFilter.Controls.Add(this.btnSearchCustomer);
            this.gbFilter.Controls.Add(this.cbFilterByOptions);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1014, 119);
            this.gbFilter.TabIndex = 4;
            this.gbFilter.Text = "Search Customer";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 22;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Calibri", 9.8F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(371, 60);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(286, 43);
            this.txtFilterValue.TabIndex = 0;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFilterValue_Validating);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddCustomer.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddCustomer.Image = global::CarRentalManagementSystem.Properties.Resources.add;
            this.btnAddCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddCustomer.ImageRotate = 0F;
            this.btnAddCustomer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddCustomer.Location = new System.Drawing.Point(770, 52);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddCustomer.Size = new System.Drawing.Size(50, 50);
            this.btnAddCustomer.TabIndex = 174;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchCustomer.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchCustomer.Image = global::CarRentalManagementSystem.Properties.Resources.find;
            this.btnSearchCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearchCustomer.ImageRotate = 0F;
            this.btnSearchCustomer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchCustomer.Location = new System.Drawing.Point(703, 52);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchCustomer.Size = new System.Drawing.Size(50, 50);
            this.btnSearchCustomer.TabIndex = 173;
            this.btnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomer_Click);
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByOptions.BorderRadius = 22;
            this.cbFilterByOptions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbFilterByOptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbFilterByOptions.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.cbFilterByOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbFilterByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByOptions.ItemHeight = 35;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "Customer ID",
            "National No"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(135, 61);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(192, 41);
            this.cbFilterByOptions.TabIndex = 172;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.CbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 168;
            this.label2.Text = "Search By :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucCustomerCard1
            // 
            this.ucCustomerCard1.BackColor = System.Drawing.Color.White;
            this.ucCustomerCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucCustomerCard1.Location = new System.Drawing.Point(0, 132);
            this.ucCustomerCard1.Name = "ucCustomerCard1";
            this.ucCustomerCard1.Size = new System.Drawing.Size(1014, 617);
            this.ucCustomerCard1.TabIndex = 5;
            // 
            // ucCustomerCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucCustomerCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ucCustomerCardWithFilter";
            this.Size = new System.Drawing.Size(1014, 749);
            this.Load += new System.EventHandler(this.UcCustomerCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.Label label2;
        private UcCustomerCard ucCustomerCard1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddCustomer;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearchCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
    }
}

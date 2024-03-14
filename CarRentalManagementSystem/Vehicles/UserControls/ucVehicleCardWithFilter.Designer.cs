﻿namespace CarRentalManagementSystem.Vehicles.UserControls
{
    partial class ucVehicleCardWithFilter
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
            this.btnAddVehicle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearchVehicle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucVehicleCard1 = new CarRentalManagementSystem.Vehicles.UserControls.ucVehicleCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.Silver;
            this.gbFilter.Controls.Add(this.btnAddVehicle);
            this.gbFilter.Controls.Add(this.btnSearchVehicle);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(950, 119);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.Text = "Search Vehicle";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddVehicle.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddVehicle.Image = global::CarRentalManagementSystem.Properties.Resources.plus1;
            this.btnAddVehicle.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddVehicle.ImageRotate = 0F;
            this.btnAddVehicle.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddVehicle.Location = new System.Drawing.Point(670, 52);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddVehicle.Size = new System.Drawing.Size(50, 50);
            this.btnAddVehicle.TabIndex = 174;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnSearchVehicle
            // 
            this.btnSearchVehicle.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchVehicle.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchVehicle.Image = global::CarRentalManagementSystem.Properties.Resources.searching;
            this.btnSearchVehicle.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearchVehicle.ImageRotate = 0F;
            this.btnSearchVehicle.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchVehicle.Location = new System.Drawing.Point(598, 52);
            this.btnSearchVehicle.Name = "btnSearchVehicle";
            this.btnSearchVehicle.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchVehicle.Size = new System.Drawing.Size(50, 50);
            this.btnSearchVehicle.TabIndex = 173;
            this.btnSearchVehicle.Click += new System.EventHandler(this.btnSearchVehicle_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
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
            this.txtFilterValue.IconRightSize = new System.Drawing.Size(28, 28);
            this.txtFilterValue.Location = new System.Drawing.Point(169, 59);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(340, 43);
            this.txtFilterValue.TabIndex = 0;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(46)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 168;
            this.label2.Text = "Vehicle ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucVehicleCard1
            // 
            this.ucVehicleCard1.BackColor = System.Drawing.Color.White;
            this.ucVehicleCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucVehicleCard1.Location = new System.Drawing.Point(0, 132);
            this.ucVehicleCard1.Name = "ucVehicleCard1";
            this.ucVehicleCard1.Size = new System.Drawing.Size(950, 522);
            this.ucVehicleCard1.TabIndex = 0;
            // 
            // ucVehicleCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ucVehicleCard1);
            this.Name = "ucVehicleCardWithFilter";
            this.Size = new System.Drawing.Size(950, 654);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucVehicleCard ucVehicleCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddVehicle;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearchVehicle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

namespace CarRentalManagementSystem
{
    partial class Form1
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
            this.ucBookingDetailsWithFilter1 = new CarRentalManagementSystem.Bookings.UserControls.ucBookingDetailsWithFilter();
            this.SuspendLayout();
            // 
            // ucBookingDetailsWithFilter1
            // 
            this.ucBookingDetailsWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucBookingDetailsWithFilter1.FilterEnabled = true;
            this.ucBookingDetailsWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ucBookingDetailsWithFilter1.Name = "ucBookingDetailsWithFilter1";
            this.ucBookingDetailsWithFilter1.Size = new System.Drawing.Size(1003, 616);
            this.ucBookingDetailsWithFilter1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 646);
            this.Controls.Add(this.ucBookingDetailsWithFilter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bookings.UserControls.ucBookingDetailsWithFilter ucBookingDetailsWithFilter1;
    }
}
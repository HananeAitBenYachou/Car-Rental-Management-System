using CarRental_BusinessLayer;
using CarRentalManagementSystem.Customers.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRentalManagementSystem.Vehicles.UserControls.ucVehicleCardWithFilter;

namespace CarRentalManagementSystem.Bookings
{
    public partial class frmAddRentalBooking : Form
    {
        private int? _VehicleID = null;
        private int? _CustomerID = null;

        private int? _BookingID = null;
        private clsRentalBooking _Booking = null;

        public event EventHandler<int?> NewBookingAdded;
        protected virtual void OnNewBookingAdded()
        {
            NewBookingAdded?.Invoke(this, _BookingID);
        }

        public frmAddRentalBooking()
        {
            InitializeComponent();
        }

        private void _Reset()
        {
            ucCustomerCardWithFilter1.CustomerFound += UcCustomerCardWithFilter1_CustomerFound;
            ucVehicleCardWithFilter1.VehicleFound += UcVehicleCardWithFilter1_VehicleFound;

            ucCustomerCardWithFilter1.FilterEnabled = true;
            ucVehicleCardWithFilter1.FilterEnabled = true;

            btnSave.Enabled = false;
            btnToVehicleInfo.Enabled = false;
            btnToBookingInfo.Enabled = false;        
        }

        private void frmAddRentalBooking_Load(object sender, EventArgs e)
        {
            _Reset();
        }

        private void UcVehicleCardWithFilter1_VehicleFound(object sender, VehicleFoundEventArgs vehicleInfo)
        {
            if(!vehicleInfo.IsAvailableForRent)
            {
                MessageBox.Show($"This car is not available for rental!", "Not Available !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnToBookingInfo.Enabled = false;
                return;
            }

            _VehicleID = vehicleInfo.VehicleID;

            btnToBookingInfo.Enabled = true;

            txtVehicleID.Text = _VehicleID.ToString();
            txtRentalPricePerDay.Text = vehicleInfo.RentalPricePerDay.ToString();

            dtpStartDate.MinDate = DateTime.Now;
            dtpStartDate.MaxDate = DateTime.Now.AddMonths(3);
            dtpStartDate.Value = dtpStartDate.MinDate;

            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
            dtpEndDate.Value = dtpEndDate.MinDate;
            dtpEndDate.MaxDate = dtpEndDate.Value.AddMonths(3);

            btnSave.Enabled = true;
        }

        private void UcCustomerCardWithFilter1_CustomerFound(object sender, int? customerID)
        {
            _CustomerID = customerID;

            btnToVehicleInfo.Enabled = true;

            txtCustomerID.Text = _CustomerID.ToString();
        }

        private void btnToVehicleInfo_Click(object sender, EventArgs e)
        {
            tcRentalBooking.SelectedTab = tpVehicleInfo;
        }

        private void btnToBookingInfo_Click(object sender, EventArgs e)
        {
            tcRentalBooking.SelectedTab = tpBookingInfo;
        }

        private void btnToVehicleInfo_EnabledChanged(object sender, EventArgs e)
        {
            tpVehicleInfo.Enabled = btnToVehicleInfo.Enabled;
        }

        private void btnToBookingInfo_EnabledChanged(object sender, EventArgs e)
        {
            tpBookingInfo.Enabled = btnToBookingInfo.Enabled;
        }

        private bool _SaveRentalBookingInfo()
        {
            _Booking = new clsRentalBooking();

            _Booking.CustomerID = _CustomerID.Value;
            _Booking.VehicleID = _VehicleID.Value;
            _Booking.RentalStartDate = dtpStartDate.Value;
            _Booking.RentalEndDate = dtpEndDate.Value;
            _Booking.PickupLocation = txtPickUpLocation.Text.Trim();
            _Booking.DropoffLocation = txtDropOffLocation.Text.Trim();
            _Booking.RentalPricePerDay = Convert.ToSingle(txtRentalPricePerDay.Text.Trim());
            _Booking.InitialCheckNotes = string.IsNullOrEmpty(txtInitialCheckNotes.Text) ? null : txtInitialCheckNotes.Text.Trim();

            if (!_Booking.Save())
            {
                MessageBox.Show("Failed to book the vehicle. Please try again.", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                MessageBox.Show("Vehicle booked successfully from " + dtpStartDate.Value.ToShortDateString() + " to " + dtpEndDate.Value.ToShortDateString() + ".", 
                                "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); _BookingID = _Booking.BookingID;
                
                txtBookingID.Text = _BookingID.ToString();

                btnSave.Enabled = false;
                ucCustomerCardWithFilter1.FilterEnabled = false;
                ucVehicleCardWithFilter1.FilterEnabled = false;

                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_SaveRentalBookingInfo())
                OnNewBookingAdded();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = dtpEndDate.Value.Date - dtpStartDate.Value.Date;
            int InitialRentalDays = (int)difference.TotalDays;
            double RentalPricePerDay = Convert.ToDouble(txtRentalPricePerDay.Text);

            nudInitialRentalDays.Value = InitialRentalDays;
            txtInitialTotalDueAmount.Text = (RentalPricePerDay * InitialRentalDays).ToString();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox txtTemp = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(txtTemp.Text.Trim()))
            {
                e.Cancel = true;
                txtTemp.Focus();
                errorProvider1.SetError(txtTemp, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTemp, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

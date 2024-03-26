using CarRental_BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static CarRentalManagementSystem.Vehicles.UserControls.UcVehicleCardWithFilter;

namespace CarRentalManagementSystem.Bookings
{
    public partial class FrmAddRentalBooking : Form
    {
        private int? _vehicleID = null;
        private int? _customerID = null;

        private int? _bookingID = null;
        private RentalBooking _booking = null;

        public event EventHandler<int?> NewBookingAdded;
        protected virtual void OnNewBookingAdded()
        {
            NewBookingAdded?.Invoke(this, _bookingID);
        }

        public FrmAddRentalBooking()
        {
            InitializeComponent();
            ucCustomerCardWithFilter1.CustomerFound += UcCustomerCardWithFilter1_CustomerFound;
            ucVehicleCardWithFilter1.VehicleFound += UcVehicleCardWithFilter1_VehicleFound;
        }

        private void Reset()
        {
            //    ucCustomerCardWithFilter1.CustomerFound += ucCustomerCardWithFilter1_CustomerFound;
            //    ucVehicleCardWithFilter1.VehicleFound += ucVehicleCardWithFilter1_VehicleFound;

            ucCustomerCardWithFilter1.FilterEnabled = true;
            ucVehicleCardWithFilter1.FilterEnabled = true;

            btnSave.Enabled = false;
            btnToVehicleInfo.Enabled = false;
            btnToBookingInfo.Enabled = false;
        }

        private void FrmAddRentalBooking_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void UcVehicleCardWithFilter1_VehicleFound(object sender, VehicleFoundEventArgs vehicleInfo)
        {
            if (!vehicleInfo.IsAvailableForRent)
            {
                MessageBox.Show($"This car is not available for rental!", "Not Available !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnToBookingInfo.Enabled = false;
                return;
            }

            _vehicleID = vehicleInfo.VehicleID;

            btnToBookingInfo.Enabled = true;

            txtVehicleID.Text = _vehicleID.ToString();
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
            _customerID = customerID;

            btnToVehicleInfo.Enabled = true;

            txtCustomerID.Text = _customerID.ToString();
        }

        private void BtnToVehicleInfo_Click(object sender, EventArgs e)
        {
            tcRentalBooking.SelectedTab = tpVehicleInfo;
        }

        private void BtnToBookingInfo_Click(object sender, EventArgs e)
        {
            tcRentalBooking.SelectedTab = tpBookingInfo;
        }

        private void BtnToVehicleInfo_EnabledChanged(object sender, EventArgs e)
        {
            tpVehicleInfo.Enabled = btnToVehicleInfo.Enabled;
        }

        private void BtnToBookingInfo_EnabledChanged(object sender, EventArgs e)
        {
            tpBookingInfo.Enabled = btnToBookingInfo.Enabled;
        }

        private bool SaveRentalBookingInfo()
        {
            _booking = new RentalBooking();

            _booking.CustomerID = _customerID.Value;
            _booking.VehicleID = _vehicleID.Value;
            _booking.RentalStartDate = dtpStartDate.Value;
            _booking.RentalEndDate = dtpEndDate.Value;
            _booking.PickupLocation = txtPickUpLocation.Text.Trim();
            _booking.DropoffLocation = txtDropOffLocation.Text.Trim();
            _booking.RentalPricePerDay = Convert.ToSingle(txtRentalPricePerDay.Text.Trim());
            _booking.InitialCheckNotes = string.IsNullOrEmpty(txtInitialCheckNotes.Text) ? null : txtInitialCheckNotes.Text.Trim();

            if (!_booking.Save())
            {
                MessageBox.Show("Failed to book the vehicle. Please try again.", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                MessageBox.Show("Vehicle booked successfully from " + dtpStartDate.Value.ToShortDateString() + " to " + dtpEndDate.Value.ToShortDateString() + ".",
                                "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); _bookingID = _booking.BookingID;

                txtBookingID.Text = _bookingID.ToString();

                btnSave.Enabled = false;
                ucCustomerCardWithFilter1.FilterEnabled = false;
                ucVehicleCardWithFilter1.FilterEnabled = false;

                return true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SaveRentalBookingInfo())
                OnNewBookingAdded();
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = dtpEndDate.Value.Date - dtpStartDate.Value.Date;
            int initialRentalDays = (int)difference.TotalDays;
            double rentalPricePerDay = Convert.ToDouble(txtRentalPricePerDay.Text);

            nudInitialRentalDays.Value = initialRentalDays;
            txtInitialTotalDueAmount.Text = (rentalPricePerDay * initialRentalDays).ToString();
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox temp = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                temp.Focus();
                errorProvider1.SetError(temp, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

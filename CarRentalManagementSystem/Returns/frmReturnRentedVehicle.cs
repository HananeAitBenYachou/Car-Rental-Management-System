using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Returns
{
    public partial class frmReturnRentedVehicle : Form
    {
        private int? _BookingID = null;
        private RentalBooking _Booking = null;

        private int? _ReturnID = null;
        private VehicleReturn _Return = null;

        public frmReturnRentedVehicle()
        {
            InitializeComponent();
        }
        public frmReturnRentedVehicle(int? bookingID)
        {
            InitializeComponent();

            _BookingID = bookingID;
        }

        private void _LoadBookingData()
        {
            ucBookingDetailsWithFilter1.FilterEnabled = false;

            if (!ucBookingDetailsWithFilter1.LoadBookingData(_BookingID))
                btnClose.PerformClick();

        }

        private void _Reset()
        {
            ucBookingDetailsWithFilter1.BookingFound += UcBookingDetailsWithFilter1_BookingFound;        
            ucBookingDetailsWithFilter1.FilterEnabled = !_BookingID.HasValue;
            btnNext.Enabled = false;
            btnSave.Enabled = false;
        }

        private void frmAddRentalBooking_Load(object sender, EventArgs e)
        {
            _Reset();

            if (_BookingID.HasValue)
                _LoadBookingData();
        }

        private void UcBookingDetailsWithFilter1_BookingFound(object sender, int? bookingID)
        {
            _Booking = RentalBooking.Find(bookingID);

            if (!_Booking.IsBookingActive)
            {
                MessageBox.Show($"You can't return this car , it is not rented !", "Not Valid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
                return;
            }

            _BookingID = bookingID;

            btnNext.Enabled = true;

            txtTransactionID.Text = _Booking.TransactionID.ToString();

            dtpActualReturnDate.Value = DateTime.Now;
            dtpActualReturnDate.MinDate = _Booking.RentalStartDate;
            dtpActualReturnDate.MaxDate = dtpActualReturnDate.Value;

            btnSave.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcReturnVehicle.SelectedTab = tpReturnInfo;
        }

        private void btnNext_EnabledChanged(object sender, EventArgs e)
        {
            tpReturnInfo.Enabled = btnNext.Enabled;
        }

        private void _SaveReturnInfo()
        {
            _Return = new VehicleReturn();
            _Return.TransactionID = _Booking.TransactionID;
            _Return.ActualReturnDate = dtpActualReturnDate.Value;
            _Return.ActualRentalDays = Convert.ToByte(nudActualRentalDays.Value);
            _Return.Mileage = Convert.ToInt16(txtMileage.Text.Trim());
            _Return.ConsumedMileage = Convert.ToInt16(txtConsumedMileage.Text.Trim());
            _Return.FinalCheckNotes = string.IsNullOrEmpty(txtFinalCheckNotes.Text) ? null : txtFinalCheckNotes.Text.Trim();
            _Return.AdditionalCharges = string.IsNullOrEmpty(txtAdditionalCharges.Text) ? 0f : Convert.ToSingle(txtAdditionalCharges.Text.Trim());
            _Return.ActualTotalDueAmount = Convert.ToSingle(txtActualTotalDueAmount.Text.Trim());

            if (!_Return.Save())
            {
                MessageBox.Show("Failed to save the data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ReturnID = _Return.ReturnID;
                txtReturnID.Text = _ReturnID.ToString();

                btnSave.Enabled = false;
                ucBookingDetailsWithFilter1.FilterEnabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveReturnInfo();
        }

        private void dtpActualReturnDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = dtpActualReturnDate.Value.Date - _Booking.RentalStartDate;

            int ActualRentalDays = (int)difference.TotalDays;

            nudActualRentalDays.Value = ActualRentalDays;

            txtActualTotalDueAmount.Text = (_Booking.RentedVehicleInfo.RentalPricePerDay * ActualRentalDays).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMileage_TextChanged(object sender, EventArgs e)
        {
            int consumedMileage = Convert.ToInt16(txtMileage.Text.Trim()) - _Booking.RentedVehicleInfo.Mileage;
            txtConsumedMileage.Text = consumedMileage.ToString();
        }

        private void txtMileage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMileage.Text))
            {
                e.Cancel = true;
                txtMileage.Focus();
                errorProvider1.SetError(txtMileage, "This field is required !");
            }

            else if (Convert.ToInt16(txtMileage.Text.Trim()) < _Booking.RentedVehicleInfo.Mileage)
            {
                e.Cancel = true;
                txtMileage.Focus();
                errorProvider1.SetError(txtMileage, "The vehicle's mileage cannot be smaller than the initial value!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMileage, null);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-';
        }
    }
}

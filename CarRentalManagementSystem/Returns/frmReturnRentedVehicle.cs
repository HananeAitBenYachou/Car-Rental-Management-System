using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Returns
{
    public partial class FrmReturnRentedVehicle : Form
    {
        private int? _bookingID = null;
        private RentalBooking _booking = null;

        private int? _returnID = null;
        private VehicleReturn _return = null;

        public FrmReturnRentedVehicle()
        {
            InitializeComponent();
        }
        public FrmReturnRentedVehicle(int? bookingID)
        {
            InitializeComponent();

            _bookingID = bookingID;
        }

        private void LoadBookingData()
        {
            ucBookingDetailsWithFilter1.FilterEnabled = false;

            if (!ucBookingDetailsWithFilter1.LoadBookingData(_bookingID))
                btnClose.PerformClick();

        }

        private void Reset()
        {
            ucBookingDetailsWithFilter1.BookingFound += UcBookingDetailsWithFilter1_BookingFound;
            ucBookingDetailsWithFilter1.FilterEnabled = !_bookingID.HasValue;
            btnNext.Enabled = false;
            btnSave.Enabled = false;
        }

        private void FrmAddRentalBooking_Load(object sender, EventArgs e)
        {
            Reset();

            if (_bookingID.HasValue)
                LoadBookingData();
        }

        private void UcBookingDetailsWithFilter1_BookingFound(object sender, int? bookingID)
        {
            _booking = RentalBooking.Find(bookingID, RentalBooking.EnFindBookingBy.BookingID);

            if (!_booking.IsBookingActive)
            {
                MessageBox.Show($"You can't return this car , it is not rented !", "Not Valid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
                return;
            }

            _bookingID = bookingID;

            btnNext.Enabled = true;

            txtTransactionID.Text = _booking.TransactionID.ToString();

            dtpActualReturnDate.Value = DateTime.Now;
            dtpActualReturnDate.MinDate = _booking.RentalStartDate;
            dtpActualReturnDate.MaxDate = dtpActualReturnDate.Value;

            btnSave.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            tcReturnVehicle.SelectedTab = tpReturnInfo;
        }

        private void BtnNext_EnabledChanged(object sender, EventArgs e)
        {
            tpReturnInfo.Enabled = btnNext.Enabled;
        }

        private void SaveReturnInfo()
        {
            _return = new VehicleReturn();
            _return.TransactionID = _booking.TransactionID;
            _return.ActualReturnDate = dtpActualReturnDate.Value;
            _return.ActualRentalDays = Convert.ToByte(nudActualRentalDays.Value);
            _return.Mileage = Convert.ToInt16(txtMileage.Text.Trim());
            _return.ConsumedMileage = Convert.ToInt16(txtConsumedMileage.Text.Trim());
            _return.FinalCheckNotes = string.IsNullOrEmpty(txtFinalCheckNotes.Text) ? null : txtFinalCheckNotes.Text.Trim();
            _return.AdditionalCharges = string.IsNullOrEmpty(txtAdditionalCharges.Text) ? 0f : Convert.ToSingle(txtAdditionalCharges.Text.Trim());
            _return.ActualTotalDueAmount = Convert.ToSingle(txtActualTotalDueAmount.Text.Trim());

            if (!_return.Save())
            {
                MessageBox.Show("Failed to save the data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Data was saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _returnID = _return.ReturnID;
                txtReturnID.Text = _returnID.ToString();

                btnSave.Enabled = false;
                ucBookingDetailsWithFilter1.FilterEnabled = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveReturnInfo();
        }

        private void DtpActualReturnDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = dtpActualReturnDate.Value.Date - _booking.RentalStartDate;

            int actualRentalDays = (int)difference.TotalDays;

            nudActualRentalDays.Value = actualRentalDays;

            txtActualTotalDueAmount.Text = (_booking.RentedVehicleInfo.RentalPricePerDay * actualRentalDays).ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtMileage_TextChanged(object sender, EventArgs e)
        {
            int consumedMileage = Convert.ToInt16(txtMileage.Text.Trim()) - _booking.RentedVehicleInfo.Mileage;
            txtConsumedMileage.Text = consumedMileage.ToString();
        }

        private void TxtMileage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMileage.Text))
            {
                e.Cancel = true;
                txtMileage.Focus();
                errorProvider1.SetError(txtMileage, "This field is required !");
            }

            else if (Convert.ToInt16(txtMileage.Text.Trim()) < _booking.RentedVehicleInfo.Mileage)
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

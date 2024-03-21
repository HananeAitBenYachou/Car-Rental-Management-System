using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Bookings.UserControls
{
    public partial class ucBookingDetailsWithFilter : UserControl
    {
        private int? _BookingID => ucBookingDetails1.BookingID;
        private RentalBooking _Booking => ucBookingDetails1.Booking;

        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled;
            }

            set
            {
                gbFilter.Enabled = value;

                if (gbFilter.Enabled)
                    txtBookingID.Focus();
            }
        }

        public event EventHandler<int?> BookingFound;
        protected virtual void OnBookingFound()
        {
            BookingFound?.Invoke(this, _BookingID);
        }

        public ucBookingDetailsWithFilter()
        {
            InitializeComponent();
        }

        public void LoadBookingData(int? bookingID)
        {
            txtBookingID.Text = bookingID.ToString();
            _FindBooking();
        }

        private void _ClearErrorProvider()
        {
            errorProvider1.SetError(txtBookingID, null);
        }

        private bool _FindBooking()
        {
            return ucBookingDetails1.LoadBookingData(Convert.ToInt16(txtBookingID.Text.Trim()));
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the booking'ID you want to search !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_FindBooking())
                OnBookingFound();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            frmAddRentalBooking form = new frmAddRentalBooking();
            form.NewBookingAdded += frmAddRentalBooking_NewBookingAdded;
            form.ShowDialog();
        }

        private void frmAddRentalBooking_NewBookingAdded(object sender, int? bookingID)
        {
            LoadBookingData(bookingID);
            _ClearErrorProvider();
            FilterEnabled = false;

            OnBookingFound();
        }

        private void txtBookingID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingID.Text))
            {
                e.Cancel = true;
                txtBookingID.Focus();
                errorProvider1.SetError(txtBookingID, "Please enter the booking'ID you want to search !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBookingID, null);
            }
        }

        private void txtBookingID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}

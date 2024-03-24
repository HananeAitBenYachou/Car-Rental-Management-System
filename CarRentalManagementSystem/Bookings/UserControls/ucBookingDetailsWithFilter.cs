using CarRental_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Bookings.UserControls
{
    public partial class UcBookingDetailsWithFilter : UserControl
    {
        public int? BookingID => ucBookingDetails1.BookingID;
        public RentalBooking Booking => ucBookingDetails1.Booking;

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
            BookingFound?.Invoke(this, BookingID);
        }

        public UcBookingDetailsWithFilter()
        {
            InitializeComponent();
        }

        public bool LoadBookingData(int? bookingID)
        {
            txtBookingID.Text = bookingID.ToString();

            if (!FindBooking())
                return false;

            OnBookingFound();
            return true;
        }

        private void ClearErrorProvider()
        {
            errorProvider1.SetError(txtBookingID, null);
        }

        private bool FindBooking()
        {
            return ucBookingDetails1.LoadBookingData(Convert.ToInt16(txtBookingID.Text.Trim()));
        }

        private void BtnSearchBooking_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the booking'ID you want to search !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FindBooking())
                OnBookingFound();
        }

        private void BtnAddBooking_Click(object sender, EventArgs e)
        {
            FrmAddRentalBooking form = new FrmAddRentalBooking();
            form.NewBookingAdded += FrmAddRentalBooking_NewBookingAdded;
            form.ShowDialog();
        }

        private void FrmAddRentalBooking_NewBookingAdded(object sender, int? bookingID)
        {
            LoadBookingData(bookingID);
            ClearErrorProvider();
            FilterEnabled = false;

            OnBookingFound();
        }

        private void TxtBookingID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingID.Text))
            {
                e.Cancel = true;
                txtBookingID.Focus();
                errorProvider1.SetError(txtBookingID, "Please enter the rental booking's ID you want to search !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBookingID, null);
            }
        }

        private void TxtBookingID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

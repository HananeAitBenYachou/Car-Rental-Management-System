using CarRental_BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Bookings
{
    public partial class frmShowBookingDetails : Form
    {
        private int? _BookingID = null;
        private RentalBooking _Booking = null;

        public frmShowBookingDetails(int? bookingID)
        {
            InitializeComponent();
            _BookingID = bookingID;
        }

        private void _LoadRentalBookingData()
        {
            _Booking = RentalBooking.Find(_BookingID);

            if (_Booking == null)
            {
                MessageBox.Show($"No booking with bookingID = {_BookingID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;

            }

            ucCustomerCard1.LoadCustomerData(_Booking.CustomerID);
            ucVehicleCard1.LoadVehicleData(_Booking.VehicleID);
            ucBookingDetails1.LoadBookingData(_Booking.BookingID);
        }

        private void frmShowBookingDetails_Load(object sender, EventArgs e)
        {
            _LoadRentalBookingData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

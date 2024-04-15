using CarRental_BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Bookings
{
    public partial class FrmShowBookingDetails : Form
    {
        private readonly int? _bookingID = null;
        private RentalBooking _booking = null;

        public FrmShowBookingDetails(int? bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
        }

        private void LoadRentalBookingData()
        {       
            _booking = RentalBooking.Find(_bookingID, RentalBooking.EnFindBookingBy.BookingID);

            if (_booking == null)
            {
                MessageBox.Show($"No booking with bookingID = {_bookingID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;
            }

            ucCustomerCard1.LoadCustomerData(_booking.CustomerID);
            ucVehicleCard1.LoadVehicleData(_booking.VehicleID);
            ucBookingDetails1.LoadBookingData(_booking.BookingID);
        }

        private void FrmShowBookingDetails_Load(object sender, EventArgs e)
        {
            LoadRentalBookingData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

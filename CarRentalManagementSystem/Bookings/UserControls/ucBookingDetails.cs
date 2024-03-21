using CarRental_BusinessLayer;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Bookings.UserControls
{
    public partial class ucBookingDetails : UserControl
    {
        public int? BookingID { get; private set; } = null;
        public RentalBooking Booking { get; private set; } = null;

        public ucBookingDetails()
        {
            InitializeComponent();
        }

        public bool LoadBookingData(int? bookingID)
        {
            Booking = RentalBooking.Find(bookingID);

            if (Booking == null)
            {
                MessageBox.Show($"No booking with BookingID = {bookingID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BookingID = Booking.BookingID;

            txtBookingID.Text = BookingID.ToString();
            txtCustomerID.Text = Booking.CustomerID.ToString();
            txtVehicleID.Text = Booking.VehicleID.ToString();
            txtRentalPricePerDay.Text = Booking.VehicleInfo.RentalPricePerDay.ToString();
            txtInitialTotalDueAmount.Text = Booking.InitialTotalDueAmount.ToString();
            txtPickUpLocation.Text = Booking.PickupLocation;
            txtDropOffLocation.Text = Booking.DropoffLocation;
            txtRentalPricePerDay.Text = Booking.RentalPricePerDay.ToString();
            txtInitialCheckNotes.Text = Booking.InitialCheckNotes ?? string.Empty;
            dtpStartDate.Value = Booking.RentalStartDate;
            dtpEndDate.Value = Booking.RentalEndDate;
            nudInitialRentalDays.Value = Booking.InitialRentalDays;

            return true;
        }

    }
}

using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class RentalBooking
    {
        private enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode;

        public enum EnFindBookingBy : byte { BookingID , TransactionID }

        public int? BookingID { get; private set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public int InitialRentalDays { get; set; }
        public float RentalPricePerDay { get; set; }
        public float InitialTotalDueAmount { get; set; }
        public string InitialCheckNotes { get; set; }

        public bool IsBookingActive { get; }
        public int TransactionID { get; }
        public Vehicle RentedVehicleInfo { get; }
        public Customer CustomerInfo { get; }

        public RentalBooking()
        {
            _mode = EnMode.AddNew;

            BookingID = null;
            CustomerID = default;
            VehicleID = default;
            RentalStartDate = default;
            RentalEndDate = default;
            PickupLocation = default;
            DropoffLocation = default;
            InitialRentalDays = default;
            RentalPricePerDay = default;
            InitialTotalDueAmount = default;
            InitialCheckNotes = null;
            IsBookingActive = false;
            TransactionID = -1;
        }
        private RentalBooking(int? bookingID, int customerID, int vehicleID, DateTime rentalStartDate,
                              DateTime rentalEndDate, string pickupLocation, string dropoffLocation,
                              int initialRentalDays, float rentalPricePerDay, float initialTotalDueAmount,
                              string initialCheckNotes)
        {
            _mode = EnMode.Update;

            BookingID = bookingID;
            CustomerID = customerID;
            VehicleID = vehicleID;
            RentalStartDate = rentalStartDate;
            RentalEndDate = rentalEndDate;
            PickupLocation = pickupLocation;
            DropoffLocation = dropoffLocation;
            InitialRentalDays = initialRentalDays;
            RentalPricePerDay = rentalPricePerDay;
            InitialTotalDueAmount = initialTotalDueAmount;
            InitialCheckNotes = initialCheckNotes;

            RentedVehicleInfo = Vehicle.Find(vehicleID);
            CustomerInfo = Customer.Find(customerID, Customer.EnFindCustomerBy.CustomerID);
            TransactionID = RentalTransaction.GetTransactionIDByBookingID(bookingID);
            IsBookingActive = IsRentalBookingActive();
        }

        public static RentalBooking Find<T>(T searchValue, EnFindBookingBy findBookingBy)
        {
            switch (findBookingBy)
            {
                case EnFindBookingBy.TransactionID:
                    return FindByTransactionID(Convert.ToInt16(searchValue));

                case EnFindBookingBy.BookingID:
                    return FindByBookingID(Convert.ToInt16(searchValue));

                default:
                    return null;
            }
        }

        private static RentalBooking FindByBookingID(int? bookingID)
        {
            int customerID = default;
            int vehicleID = default;
            DateTime rentalStartDate = default;
            DateTime rentalEndDate = default;
            string pickupLocation = default;
            string dropoffLocation = default;
            int initialRentalDays = default;
            float rentalPricePerDay = default;
            float initialTotalDueAmount = default;
            string initialCheckNotes = default;

            bool isFound = RentalBookingData.GetRentalBookingInfoByID(bookingID, ref customerID, ref vehicleID,
                                                                      ref rentalStartDate, ref rentalEndDate,
                                                                      ref pickupLocation, ref dropoffLocation,
                                                                      ref initialRentalDays, ref rentalPricePerDay,
                                                                      ref initialTotalDueAmount, ref initialCheckNotes);

            if (isFound)
                return new RentalBooking(bookingID, customerID, vehicleID, rentalStartDate, rentalEndDate,
                                         pickupLocation, dropoffLocation, initialRentalDays, rentalPricePerDay,
                                         initialTotalDueAmount, initialCheckNotes);
            else
                return null;
        }

        private static RentalBooking FindByTransactionID(int? transactionID)
        {
            int? bookingID = default;
            int customerID = default;
            int vehicleID = default;
            DateTime rentalStartDate = default;
            DateTime rentalEndDate = default;
            string pickupLocation = default;
            string dropoffLocation = default;
            int initialRentalDays = default;
            float rentalPricePerDay = default;
            float initialTotalDueAmount = default;
            string initialCheckNotes = default;

            bool isFound = RentalBookingData.GetRentalBookingInfoByTransactionID(transactionID , ref bookingID, ref customerID, ref vehicleID,
                                                                      ref rentalStartDate, ref rentalEndDate,
                                                                      ref pickupLocation, ref dropoffLocation,
                                                                      ref initialRentalDays, ref rentalPricePerDay,
                                                                      ref initialTotalDueAmount, ref initialCheckNotes);

            if (isFound)
                return new RentalBooking(bookingID, customerID, vehicleID, rentalStartDate, rentalEndDate,
                                         pickupLocation, dropoffLocation, initialRentalDays, rentalPricePerDay,
                                         initialTotalDueAmount, initialCheckNotes);
            else
                return null;
        }

        public static bool DoesRentalBookingExist(int? bookingID)
        {
            return RentalBookingData.DoesRentalBookingExist(bookingID);
        }

        private bool IsRentalBookingActive()
        {
            return RentalBookingData.IsRentalBookingActive(BookingID);
        }

        private bool AddNewRentalBooking()
        {
            BookingID = RentalBookingData.AddNewRentalBooking(CustomerID, VehicleID, RentalStartDate, RentalEndDate,
                                                              PickupLocation, DropoffLocation, RentalPricePerDay,
                                                              InitialCheckNotes);
            return BookingID.HasValue;
        }

        private bool UpdateRentalBooking()
        {
            return RentalBookingData.UpdateRentalBookingInfo(BookingID, CustomerID, VehicleID, RentalStartDate,
                                                             RentalEndDate, PickupLocation, DropoffLocation,
                                                             RentalPricePerDay, InitialCheckNotes);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewRentalBooking())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateRentalBooking();

            }
            return false;
        }

        public static DataTable GetAllRentalBookings()
        {
            return RentalBookingData.GetAllRentalBookings();
        }

        public static DataTable GetAllRentalBookingsByDateRange(DateTime startDate, DateTime endDate)
        {
            return RentalBookingData.GetAllRentalBookingsByDateRange(startDate, endDate);
        }

        public static int GetTotalRentalBookingsCount()
        {
            return RentalBookingData.GetTotalRentalBookingsCount();
        }

    }
}
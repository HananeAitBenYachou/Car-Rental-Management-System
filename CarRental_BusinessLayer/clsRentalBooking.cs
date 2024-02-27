using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsRentalBooking
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? BookingID { get; private set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public byte InitialRentalDays { get; set; }
        public float RentalPricePerDay { get; set; }
        public float InitialTotalDueAmount { get; set; }
        public string InitialCheckNotes { get; set; }

        public clsRentalBooking()
        {
            _Mode = enMode.AddNew;
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
        }
        private clsRentalBooking(int? BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, byte InitialRentalDays, float RentalPricePerDay, float InitialTotalDueAmount, string InitialCheckNotes)
        {
            _Mode = enMode.Update;
            this.BookingID = BookingID;
            this.CustomerID = CustomerID;
            this.VehicleID = VehicleID;
            this.RentalStartDate = RentalStartDate;
            this.RentalEndDate = RentalEndDate;
            this.PickupLocation = PickupLocation;
            this.DropoffLocation = DropoffLocation;
            this.InitialRentalDays = InitialRentalDays;
            this.RentalPricePerDay = RentalPricePerDay;
            this.InitialTotalDueAmount = InitialTotalDueAmount;
            this.InitialCheckNotes = InitialCheckNotes;
        }

        public static clsRentalBooking Find(int? BookingID)
        {
            int CustomerID = default;
            int VehicleID = default;
            DateTime RentalStartDate = default;
            DateTime RentalEndDate = default;
            string PickupLocation = default;
            string DropoffLocation = default;
            byte InitialRentalDays = default;
            float RentalPricePerDay = default;
            float InitialTotalDueAmount = default;
            string InitialCheckNotes = default;

            bool isFound = clsRentalBookingData.GetRentalBookingInfoByID(BookingID, ref CustomerID, ref VehicleID, ref RentalStartDate, ref RentalEndDate, ref PickupLocation, ref DropoffLocation, ref InitialRentalDays, ref RentalPricePerDay, ref InitialTotalDueAmount, ref InitialCheckNotes);

            if (isFound)
                return new clsRentalBooking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);
            else
                return null;
        }

        public static bool DoesRentalBookingExist(int? BookingID)
        {
            return clsRentalBookingData.DoesRentalBookingExist(BookingID);
        }

        private bool _AddNewRentalBooking()
        {
            BookingID = clsRentalBookingData.AddNewRentalBooking(CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);
            return BookingID.HasValue;
        }

        private bool _UpdateRentalBooking()
        {
            return clsRentalBookingData.UpdateRentalBookingInfo(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalBooking())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRentalBooking();

            }
            return false;
        }

        public static bool DeleteRentalBooking(int? BookingID)
        {
            return clsRentalBookingData.DeleteRentalBooking(BookingID);
        }

        public static DataTable GetAllRentalBookings()
        {
            return clsRentalBookingData.GetAllRentalBookings();
        }

    }
}
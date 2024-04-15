using CarRental_DataAccessLayer;
using System;
using System.Data;
using static CarRental_BusinessLayer.RentalBooking;

namespace CarRental_BusinessLayer
{
    public class VehicleReturn
    {
        private enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode;
        public int? ReturnID { get; private set; }
        public DateTime ActualReturnDate { get; set; }
        public byte ActualRentalDays { get; set; }
        public short Mileage { get; set; }
        public short ConsumedMileage { get; set; }
        public string FinalCheckNotes { get; set; }
        public float AdditionalCharges { get; set; }
        public float ActualTotalDueAmount { get; set; }
        public int TransactionID { get; set; }

        public RentalBooking RentalBookingInfo { get; }

        public VehicleReturn()
        {
            _mode = EnMode.AddNew;
            ReturnID = null;
            ActualReturnDate = default;
            ActualRentalDays = default;
            Mileage = default;
            ConsumedMileage = default;
            FinalCheckNotes = null;
            AdditionalCharges = default;
            ActualTotalDueAmount = default;
            TransactionID = default;
        }
        private VehicleReturn(int? returnID, DateTime actualReturnDate, byte actualRentalDays, short mileage,
                              short consumedMileage, string finalCheckNotes, float additionalCharges,
                              float actualTotalDueAmount, int transactionID)
        {
            _mode = EnMode.Update;
            ReturnID = returnID;
            ActualReturnDate = actualReturnDate;
            ActualRentalDays = actualRentalDays;
            Mileage = mileage;
            ConsumedMileage = consumedMileage;
            FinalCheckNotes = finalCheckNotes;
            AdditionalCharges = additionalCharges;
            ActualTotalDueAmount = actualTotalDueAmount;
            TransactionID = transactionID;

            RentalBookingInfo = RentalBooking.Find(TransactionID, EnFindBookingBy.TransactionID);
        }

        public static VehicleReturn Find(int? returnID)
        {
            DateTime actualReturnDate = default;
            byte actualRentalDays = default;
            short mileage = default;
            short consumedMileage = default;
            string finalCheckNotes = default;
            float additionalCharges = default;
            float actualTotalDueAmount = default;
            int transactionID = default;

            bool isFound = VehicleReturnData.GetVehicleReturnInfoByID(returnID, ref actualReturnDate, ref actualRentalDays,
                                                                      ref mileage, ref consumedMileage, ref finalCheckNotes,
                                                                      ref additionalCharges, ref actualTotalDueAmount, ref transactionID);

            if (isFound)
                return new VehicleReturn(returnID, actualReturnDate, actualRentalDays, mileage, consumedMileage,
                                         finalCheckNotes, additionalCharges, actualTotalDueAmount, transactionID);
            else
                return null;
        }

        public static bool DoesVehicleReturnExist(int? returnID)
        {
            return VehicleReturnData.DoesVehicleReturnExist(returnID);
        }

        private bool AddNewVehicleReturn()
        {
            ReturnID = VehicleReturnData.AddNewVehicleReturn(ActualReturnDate, ActualRentalDays, Mileage,
                                                             ConsumedMileage, FinalCheckNotes, AdditionalCharges,
                                                             ActualTotalDueAmount, TransactionID);
            return ReturnID.HasValue;
        }

        private bool UpdateVehicleReturn()
        {
            return VehicleReturnData.UpdateVehicleReturnInfo(ReturnID, ActualReturnDate, ActualRentalDays, Mileage,
                                                             ConsumedMileage, FinalCheckNotes, AdditionalCharges,
                                                             ActualTotalDueAmount, TransactionID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewVehicleReturn())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateVehicleReturn();

            }
            return false;
        }

        public static DataTable GetAllVehicleReturns()
        {
            return VehicleReturnData.GetAllVehicleReturns();
        }

        public static DataTable GetAllVehicleReturnsByDateRange(DateTime startDate, DateTime endDate)
        {
            return VehicleReturnData.GetAllVehicleReturnsByDateRange(startDate,endDate);
        }

        public static int GetTotalVehicleReturnsCount()
        {
            return VehicleReturnData.GetTotalVehicleReturnsCount();
        }
    }
}
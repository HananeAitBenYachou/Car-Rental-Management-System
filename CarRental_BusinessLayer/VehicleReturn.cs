using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class VehicleReturn
    {
        private enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? ReturnID { get; private set; }
        public DateTime ActualReturnDate { get; set; }
        public byte ActualRentalDays { get; set; }
        public short Mileage { get; set; }
        public short ConsumedMileage { get; set; }
        public string FinalCheckNotes { get; set; }
        public float AdditionalCharges { get; set; }
        public float ActualTotalDueAmount { get; set; }
        public int TransactionID { get; set; }

        public RentalTransaction TransactionInfo { get; }

        public VehicleReturn()
        {
            _Mode = enMode.AddNew;
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
            _Mode = enMode.Update;
            ReturnID = returnID;
            ActualReturnDate = actualReturnDate;
            ActualRentalDays = actualRentalDays;
            Mileage = mileage;
            ConsumedMileage = consumedMileage;
            FinalCheckNotes = finalCheckNotes;
            AdditionalCharges = additionalCharges;
            ActualTotalDueAmount = actualTotalDueAmount;
            TransactionID = transactionID;

            TransactionInfo = RentalTransaction.Find<int?>(transactionID, RentalTransaction.enFindTransactionBy.TransactionID);
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
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (AddNewVehicleReturn())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return UpdateVehicleReturn();

            }
            return false;
        }

        public static DataTable GetAllVehicleReturns()
        {
            return VehicleReturnData.GetAllVehicleReturns();
        }
    }
}
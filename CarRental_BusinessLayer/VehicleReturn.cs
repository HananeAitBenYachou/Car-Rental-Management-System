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
        private VehicleReturn(int? ReturnID, DateTime ActualReturnDate, byte ActualRentalDays,
            short Mileage, short ConsumedMileage, string FinalCheckNotes,
            float AdditionalCharges, float ActualTotalDueAmount, int TransactionID)
        {
            _Mode = enMode.Update;
            this.ReturnID = ReturnID;
            this.ActualReturnDate = ActualReturnDate;
            this.ActualRentalDays = ActualRentalDays;
            this.Mileage = Mileage;
            this.ConsumedMileage = ConsumedMileage;
            this.FinalCheckNotes = FinalCheckNotes;
            this.AdditionalCharges = AdditionalCharges;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TransactionID = TransactionID;

            this.TransactionInfo = RentalTransaction.Find<int?>(TransactionID, RentalTransaction.enFindTransactionBy.TransactionID);
        }

        public static VehicleReturn Find(int? ReturnID)
        {
            DateTime ActualReturnDate = default;
            byte ActualRentalDays = default;
            short Mileage = default;
            short ConsumedMileage = default;
            string FinalCheckNotes = default;
            float AdditionalCharges = default;
            float ActualTotalDueAmount = default;
            int TransactionID = default;

            bool isFound = VehicleReturnData.GetVehicleReturnInfoByID(ReturnID, ref ActualReturnDate, ref ActualRentalDays, ref Mileage, ref ConsumedMileage, ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount, ref TransactionID);

            if (isFound)
                return new VehicleReturn(ReturnID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, TransactionID);
            else
                return null;
        }

        public static bool DoesVehicleReturnExist(int? ReturnID)
        {
            return VehicleReturnData.DoesVehicleReturnExist(ReturnID);
        }

        private bool _AddNewVehicleReturn()
        {
            ReturnID = VehicleReturnData.AddNewVehicleReturn(ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, TransactionID);
            return ReturnID.HasValue;
        }

        private bool _UpdateVehicleReturn()
        {
            return VehicleReturnData.UpdateVehicleReturnInfo(ReturnID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, TransactionID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleReturn())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateVehicleReturn();

            }
            return false;
        }

        public static DataTable GetAllVehicleReturns()
        {
            return VehicleReturnData.GetAllVehicleReturns();
        }
    }
}
using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsVehicleReturn
    {
        private enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? ReturenID { get; private set; }
        public DateTime ActualReturnDate { get; set; }
        public byte ActualRentalDays { get; set; }
        public short Mileage { get; set; }
        public short ConsumedMileage { get; set; }
        public string FinalCheckNotes { get; set; }
        public float AdditionalCharges { get; set; }
        public float ActualTotalDueAmount { get; set; }
        public int TransactionID { get; set; }
        public clsRentalTransaction TransactionInfo { get; }

        public clsVehicleReturn()
        {
            _Mode = enMode.AddNew;
            ReturenID = null;
            ActualReturnDate = default;
            ActualRentalDays = default;
            Mileage = default;
            ConsumedMileage = default;
            FinalCheckNotes = null;
            AdditionalCharges = default;
            ActualTotalDueAmount = default;
            TransactionID = default;
        }
        private clsVehicleReturn(int? ReturenID, DateTime ActualReturnDate, byte ActualRentalDays,
            short Mileage, short ConsumedMileage, string FinalCheckNotes, 
            float AdditionalCharges, float ActualTotalDueAmount, int TransactionID)
        {
            _Mode = enMode.Update;
            this.ReturenID = ReturenID;
            this.ActualReturnDate = ActualReturnDate;
            this.ActualRentalDays = ActualRentalDays;
            this.Mileage = Mileage;
            this.ConsumedMileage = ConsumedMileage;
            this.FinalCheckNotes = FinalCheckNotes;
            this.AdditionalCharges = AdditionalCharges;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TransactionID = TransactionID;

            this.TransactionInfo = clsRentalTransaction.Find<int?>(TransactionID , clsRentalTransaction.enFindTransactionBy.TransactionID);
        }

        public static clsVehicleReturn Find(int? ReturenID)
        {
            DateTime ActualReturnDate = default;
            byte ActualRentalDays = default;
            short Mileage = default;
            short ConsumedMileage = default;
            string FinalCheckNotes = default;
            float AdditionalCharges = default;
            float ActualTotalDueAmount = default;
            int TransactionID = default;

            bool isFound = clsVehicleReturnData.GetVehicleReturnInfoByID(ReturenID, ref ActualReturnDate, ref ActualRentalDays, ref Mileage, ref ConsumedMileage, ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount, ref TransactionID);

            if (isFound)
                return new clsVehicleReturn(ReturenID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, TransactionID);
            else
                return null;
        }

        public static bool DoesVehicleReturnExist(int? ReturenID)
        {
            return clsVehicleReturnData.DoesVehicleReturnExist(ReturenID);
        }

        private bool _AddNewVehicleReturn()
        {
            ReturenID = clsVehicleReturnData.AddNewVehicleReturn(ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, TransactionID);
            return ReturenID.HasValue;
        }

        private bool _UpdateVehicleReturn()
        {
            return clsVehicleReturnData.UpdateVehicleReturnInfo(ReturenID, ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, TransactionID);
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
            return clsVehicleReturnData.GetAllVehicleReturns();
        }
    }
}
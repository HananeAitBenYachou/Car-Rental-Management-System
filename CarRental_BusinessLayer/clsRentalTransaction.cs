using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsRentalTransaction
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? TransactionID { get; private set; }
        public int BookingID { get; set; }
        public int? ReturnID { get; set; }
        public float PaidInitialTotalDueAmount { get; set; }
        public float? ActualTotalDueAmount { get; set; }
        public float? TotalRemaining { get; set; }
        public float? TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? UpdatedTransactionDate { get; set; }

        public clsRentalTransaction()
        {
            _Mode = enMode.AddNew;
            TransactionID = null;
            BookingID = default;
            ReturnID = null;
            PaidInitialTotalDueAmount = default;
            ActualTotalDueAmount = null;
            TotalRemaining = null;
            TotalRefundedAmount = null;
            TransactionDate = default;
            UpdatedTransactionDate = null;
        }
        private clsRentalTransaction(int? TransactionID, int BookingID, int? ReturnID, float PaidInitialTotalDueAmount, float? ActualTotalDueAmount, float? TotalRemaining, float? TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate)
        {
            _Mode = enMode.Update;
            this.TransactionID = TransactionID;
            this.BookingID = BookingID;
            this.ReturnID = ReturnID;
            this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TotalRemaining = TotalRemaining;
            this.TotalRefundedAmount = TotalRefundedAmount;
            this.TransactionDate = TransactionDate;
            this.UpdatedTransactionDate = UpdatedTransactionDate;
        }

        public static clsRentalTransaction Find(int? TransactionID)
        {
            int BookingID = default;
            int? ReturnID = default;
            float PaidInitialTotalDueAmount = default;
            float? ActualTotalDueAmount = default;
            float? TotalRemaining = default;
            float? TotalRefundedAmount = default;
            DateTime TransactionDate = default;
            DateTime? UpdatedTransactionDate = default;

            bool isFound = clsRentalTransactionData.GetRentalTransactionInfoByID(TransactionID, ref BookingID, ref ReturnID, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate);

            if (isFound)
                return new clsRentalTransaction(TransactionID, BookingID, ReturnID, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            else
                return null;
        }

        public static bool DoesRentalTransactionExist(int? TransactionID)
        {
            return clsRentalTransactionData.DoesRentalTransactionExist(TransactionID);
        }

        private bool _AddNewRentalTransaction()
        {
            TransactionID = clsRentalTransactionData.AddNewRentalTransaction(BookingID, ReturnID, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            return TransactionID.HasValue;
        }

        private bool _UpdateRentalTransaction()
        {
            return clsRentalTransactionData.UpdateRentalTransactionInfo(TransactionID, BookingID, ReturnID, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalTransaction())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRentalTransaction();

            }
            return false;
        }

        public static bool DeleteRentalTransaction(int? TransactionID)
        {
            return clsRentalTransactionData.DeleteRentalTransaction(TransactionID);
        }

        public static DataTable GetAllRentalTransactions()
        {
            return clsRentalTransactionData.GetAllRentalTransactions();
        }
    }
}
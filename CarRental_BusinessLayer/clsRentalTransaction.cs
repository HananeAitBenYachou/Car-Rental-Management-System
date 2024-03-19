using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsRentalTransaction
    {
        public enum enFindTransactionBy : byte { TransactionID , BookingID }
        public int? TransactionID { get; private set; }
        public int BookingID { get; set; }
        public int? ReturnID { get; set; }
        public float PaidInitialTotalDueAmount { get; set; }
        public float? ActualTotalDueAmount { get; set; }
        public float? TotalRemaining { get; set; }
        public float? TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? UpdatedTransactionDate { get; set; }

        public clsRentalBooking RentalBookingInfo { get; }
        public clsVehicleReturn ReturnInfo { get; }

        public clsRentalTransaction()
        {
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

        private clsRentalTransaction(int? TransactionID, int BookingID, int? ReturnID, 
            float PaidInitialTotalDueAmount, float? ActualTotalDueAmount, float? TotalRemaining, 
            float? TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate)
        {
            this.TransactionID = TransactionID;
            this.BookingID = BookingID;
            this.ReturnID = ReturnID;
            this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TotalRemaining = TotalRemaining;
            this.TotalRefundedAmount = TotalRefundedAmount;
            this.TransactionDate = TransactionDate;
            this.UpdatedTransactionDate = UpdatedTransactionDate;

            this.RentalBookingInfo = clsRentalBooking.Find(BookingID);
            this.ReturnInfo = clsVehicleReturn.Find(ReturnID);
        }

        public static clsRentalTransaction Find<T>(T searchValue , enFindTransactionBy findTransactionBy)
        {
            switch(findTransactionBy)
            {
                case enFindTransactionBy.TransactionID:
                    FindByTransactionID(Convert.ToInt16(searchValue));
                    break;

                case enFindTransactionBy.BookingID:
                    FindByBookingID(Convert.ToInt16(searchValue));
                    break;
            }

            return null;
        }

        private static clsRentalTransaction FindByTransactionID(int? TransactionID)
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

        private static clsRentalTransaction FindByBookingID(int BookingID)
        {
            int? TransactionID = default;
            int? ReturnID = default;
            float PaidInitialTotalDueAmount = default;
            float? ActualTotalDueAmount = default;
            float? TotalRemaining = default;
            float? TotalRefundedAmount = default;
            DateTime TransactionDate = default;
            DateTime? UpdatedTransactionDate = default;

            bool isFound = clsRentalTransactionData.GetRentalTransactionInfoByBookingID(BookingID , ref TransactionID, ref ReturnID, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate);

            if (isFound)
                return new clsRentalTransaction(TransactionID, BookingID, ReturnID, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            else
                return null;
        }

        public static bool DoesRentalTransactionExist(int? TransactionID)
        {
            return clsRentalTransactionData.DoesRentalTransactionExist(TransactionID);
        }

        public static DataTable GetAllRentalTransactions()
        {
            return clsRentalTransactionData.GetAllRentalTransactions();
        }
    }
}
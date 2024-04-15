using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class RentalTransaction
    {
        public enum EnFindTransactionBy : byte { TransactionID, BookingID }

        public int? TransactionID { get; private set; }
        public int BookingID { get; set; }
        public int? ReturnID { get; set; }
        public float PaidInitialTotalDueAmount { get; set; }
        public float? ActualTotalDueAmount { get; set; }
        public float? TotalRemaining { get; set; }
        public float? TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? UpdatedTransactionDate { get; set; }

        public RentalBooking RentalBookingInfo { get; }
        public VehicleReturn ReturnInfo { get; }

        public RentalTransaction()
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

        private RentalTransaction(int? transactionID, int bookingID, int? returnID, float paidInitialTotalDueAmount,
                                  float? actualTotalDueAmount, float? totalRemaining, float? totalRefundedAmount,
                                  DateTime transactionDate, DateTime? updatedTransactionDate)
        {
            TransactionID = transactionID;
            BookingID = bookingID;
            ReturnID = returnID;
            PaidInitialTotalDueAmount = paidInitialTotalDueAmount;
            ActualTotalDueAmount = actualTotalDueAmount;
            TotalRemaining = totalRemaining;
            TotalRefundedAmount = totalRefundedAmount;
            TransactionDate = transactionDate;
            UpdatedTransactionDate = updatedTransactionDate;

            RentalBookingInfo = RentalBooking.Find(TransactionID, RentalBooking.EnFindBookingBy.TransactionID);
            ReturnInfo = VehicleReturn.Find(returnID);
        }

        public static RentalTransaction Find<T>(T searchValue, EnFindTransactionBy findTransactionBy)
        {
            switch (findTransactionBy)
            {
                case EnFindTransactionBy.TransactionID:
                    return FindByTransactionID(Convert.ToInt16(searchValue));

                case EnFindTransactionBy.BookingID:
                    return FindByBookingID(Convert.ToInt16(searchValue));

                default:
                    return null;
            }
        }

        private static RentalTransaction FindByTransactionID(int? TransactionID)
        {
            int bookingID = default;
            int? returnID = default;
            float paidInitialTotalDueAmount = default;
            float? actualTotalDueAmount = default;
            float? totalRemaining = default;
            float? totalRefundedAmount = default;
            DateTime transactionDate = default;
            DateTime? updatedTransactionDate = default;

            bool isFound = RentalTransactionData.GetRentalTransactionInfoByID(TransactionID, ref bookingID, ref returnID, ref paidInitialTotalDueAmount,
                                                                              ref actualTotalDueAmount, ref totalRemaining, ref totalRefundedAmount,
                                                                              ref transactionDate, ref updatedTransactionDate);

            if (isFound)
                return new RentalTransaction(TransactionID, bookingID, returnID, paidInitialTotalDueAmount,
                                             actualTotalDueAmount, totalRemaining, totalRefundedAmount, transactionDate,
                                             updatedTransactionDate);
            else
                return null;
        }

        private static RentalTransaction FindByBookingID(int BookingID)
        {
            int? transactionID = default;
            int? returnID = default;
            float paidInitialTotalDueAmount = default;
            float? actualTotalDueAmount = default;
            float? totalRemaining = default;
            float? totalRefundedAmount = default;
            DateTime transactionDate = default;
            DateTime? updatedTransactionDate = default;

            bool isFound = RentalTransactionData.GetRentalTransactionInfoByBookingID(BookingID, ref transactionID, ref returnID,
                                                                                     ref paidInitialTotalDueAmount, ref actualTotalDueAmount, ref totalRemaining,
                                                                                     ref totalRefundedAmount, ref transactionDate, ref updatedTransactionDate);

            if (isFound)
                return new RentalTransaction(transactionID, BookingID, returnID, paidInitialTotalDueAmount,
                                             actualTotalDueAmount, totalRemaining, totalRefundedAmount, transactionDate,
                                             updatedTransactionDate);
            else
                return null;
        }

        public static bool DoesRentalTransactionExist(int? transactionID)
        {
            return RentalTransactionData.DoesRentalTransactionExist(transactionID);
        }

        public static DataTable GetAllRentalTransactions()
        {
            return RentalTransactionData.GetAllRentalTransactions();
        }

        public static DataTable GetAllRentalTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            return RentalTransactionData.GetAllRentalTransactionsByDateRange(startDate,endDate);
        }

        public static int GetTransactionIDByBookingID(int? bookingID)
        {
            return RentalTransactionData.GetTransactionIDByBookingID(bookingID);
        }

        public static int GetTotalRentalTransactionsCount()
        {
            return RentalTransactionData.GetTotalRentalTransactionsCount();
        }

        public static DataTable GetTotalProfitByDateRange(DateTime startDate, DateTime endDate)
        {
            return RentalTransactionData.GetTotalProfitByDateRange(startDate, endDate);
        }

        public static DataTable GetMonthlyRevenue()
        {
            return RentalTransactionData.GetMonthlyRevenue();
        }

    }
}
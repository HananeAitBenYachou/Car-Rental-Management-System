using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class RentalTransactionData
    {
        public static bool GetRentalTransactionInfoByID(int? transactionID, ref int bookingID, ref int? returnID,
                                                        ref float paidInitialTotalDueAmount, ref float? actualTotalDueAmount, ref float? totalRemaining,
                                                        ref float? totalRefundedAmount, ref DateTime transactionDate, ref DateTime? UpdatedTransactionDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalTransactionInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TransactionID", (object)transactionID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                bookingID = (int)reader["BookingID"];

                                returnID = (reader["ReturnID"] != DBNull.Value) ? (int?)reader["ReturnID"] : null;

                                paidInitialTotalDueAmount = Convert.ToSingle(reader["PaidInitialTotalDueAmount"]);

                                if ((reader["ActualTotalDueAmount"] != DBNull.Value))
                                {
                                    actualTotalDueAmount = Convert.ToSingle(reader["ActualTotalDueAmount"]);
                                }
                                else
                                {
                                    actualTotalDueAmount = null;
                                }

                                if ((reader["TotalRemaining"] != DBNull.Value))
                                {
                                    totalRemaining = Convert.ToSingle(reader["TotalRemaining"]);
                                }
                                else
                                {
                                    totalRemaining = null;
                                }

                                if (reader["TotalRefundedAmount"] == DBNull.Value)
                                {
                                    totalRefundedAmount = null;
                                }
                                else
                                {
                                    totalRefundedAmount = Convert.ToSingle(reader["TotalRefundedAmount"]);
                                }

                                transactionDate = (DateTime)reader["TransactionDate"];

                                UpdatedTransactionDate = (reader["UpdatedTransactionDate"] != DBNull.Value) ? (DateTime?)reader["UpdatedTransactionDate"] : null;

                            }

                            else
                            {
                                // The record wasn't found !
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool GetRentalTransactionInfoByBookingID(int bookingID, ref int? transactionID, ref int? returnID,
                                                               ref float paidInitialTotalDueAmount, ref float? actualTotalDueAmount,
                                                               ref float? totalRemaining, ref float? totalRefundedAmount, ref DateTime transactionDate,
                                                               ref DateTime? updatedTransactionDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalTransactionInfoByBookingID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", bookingID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                returnID = (reader["ReturnID"] != DBNull.Value) ? (int?)reader["ReturnID"] : null;

                                transactionID = (reader["TransactionID"] != DBNull.Value) ? (int?)reader["TransactionID"] : null;

                                paidInitialTotalDueAmount = Convert.ToSingle(reader["PaidInitialTotalDueAmount"]);

                                if ((reader["ActualTotalDueAmount"] != DBNull.Value))
                                {
                                    actualTotalDueAmount = Convert.ToSingle(reader["ActualTotalDueAmount"]);
                                }
                                else
                                {
                                    actualTotalDueAmount = null;
                                }

                                if ((reader["TotalRemaining"] != DBNull.Value))
                                {
                                    totalRemaining = Convert.ToSingle(reader["TotalRemaining"]);
                                }
                                else
                                {
                                    totalRemaining = null;
                                }

                                if ((reader["TotalRefundedAmount"] != DBNull.Value))
                                {
                                    totalRefundedAmount = Convert.ToSingle(reader["TotalRefundedAmount"]);
                                }
                                else
                                {
                                    totalRefundedAmount = null;
                                }

                                transactionDate = (DateTime)reader["TransactionDate"];

                                updatedTransactionDate = (reader["UpdatedTransactionDate"] != DBNull.Value) ? (DateTime?)reader["UpdatedTransactionDate"] : null;

                            }

                            else
                            {
                                // The record wasn't found !
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool DoesRentalTransactionExist(int? transactionID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfRentalTransactionExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TransactionID", (object)transactionID ?? DBNull.Value);

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        isFound = (int)returnValue.Value == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static int GetTransactionIDByBookingID(int? bookingID)
        {
            int TransactionID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTransactionIDByBookingID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)bookingID ?? DBNull.Value);

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        TransactionID = (int)returnValue.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
                TransactionID = -1;
            }
            return TransactionID;

        }

        public static DataTable GetAllRentalTransactions()
        {
            DataTable rentalTransactionsDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllRentalTransactions", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                rentalTransactionsDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return rentalTransactionsDatatable;
        }

        public static DataTable GetAllRentalTransactionsByDateRange(DateTime startDate , DateTime endDate)
        {
            DataTable rentalTransactionsDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllRentalTransactionsByDateRange", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                rentalTransactionsDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return rentalTransactionsDatatable;
        }

        public static int GetTotalRentalTransactionsCount()
        {
            int totallRentalTransactionsCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalTransactionsCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        totallRentalTransactionsCount = (int)returnValue.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                totallRentalTransactionsCount = 0;
            }
            return totallRentalTransactionsCount;
        }

        public static DataTable GetTotalProfitByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTotalProfitByDateRange", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return dataTable;
        }

        public static DataTable GetMonthlyRevenue()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetMonthlyRevenue", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return dataTable;
        }

    }
}
using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class clsRentalTransactionData
    {
        public static bool GetRentalTransactionInfoByID(int? TransactionID, ref int BookingID, ref int? ReturnID,
            ref float PaidInitialTotalDueAmount, ref float? ActualTotalDueAmount,
            ref float? TotalRemaining, ref float? TotalRefundedAmount, ref DateTime TransactionDate,
            ref DateTime? UpdatedTransactionDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalTransactionInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TransactionID", (object)TransactionID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                BookingID = (int)reader["BookingID"];

                                ReturnID = (reader["ReturnID"] != DBNull.Value) ? (int?)reader["ReturnID"] : null;

                                PaidInitialTotalDueAmount = (float)reader["PaidInitialTotalDueAmount"];

                                ActualTotalDueAmount = (reader["ActualTotalDueAmount"] != DBNull.Value) ? (float?)reader["ActualTotalDueAmount"] : null;

                                TotalRemaining = (reader["TotalRemaining"] != DBNull.Value) ? (float?)reader["TotalRemaining"] : null;

                                TotalRefundedAmount = (reader["TotalRefundedAmount"] != DBNull.Value) ? (float?)reader["TotalRefundedAmount"] : null;

                                TransactionDate = (DateTime)reader["TransactionDate"];

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
                clsErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool GetRentalTransactionInfoByBookingID(int BookingID, ref int? TransactionID, ref int? ReturnID,
            ref float PaidInitialTotalDueAmount, ref float? ActualTotalDueAmount,
            ref float? TotalRemaining, ref float? TotalRefundedAmount, ref DateTime TransactionDate,
            ref DateTime? UpdatedTransactionDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalTransactionInfoByBookingID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", BookingID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                ReturnID = (reader["ReturnID"] != DBNull.Value) ? (int?)reader["ReturnID"] : null;

                                TransactionID = (reader["TransactionID"] != DBNull.Value) ? (int?)reader["TransactionID"] : null;

                                PaidInitialTotalDueAmount = Convert.ToSingle(reader["PaidInitialTotalDueAmount"]);

                                if ((reader["ActualTotalDueAmount"] != DBNull.Value))
                                {
                                    ActualTotalDueAmount = Convert.ToSingle(reader["ActualTotalDueAmount"]);
                                }
                                else
                                {
                                    ActualTotalDueAmount = null;
                                }

                                if ((reader["TotalRemaining"] != DBNull.Value))
                                {
                                    TotalRemaining = Convert.ToSingle(reader["TotalRemaining"]);
                                }
                                else
                                {
                                    TotalRemaining = null;
                                }

                                if ((reader["TotalRefundedAmount"] != DBNull.Value))
                                {
                                    TotalRefundedAmount = Convert.ToSingle(reader["TotalRefundedAmount"]);
                                }
                                else
                                {
                                    TotalRefundedAmount = null;
                                }

                                TransactionDate = (DateTime)reader["TransactionDate"];

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
                clsErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static bool DoesRentalTransactionExist(int? TransactionID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfRentalTransactionExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TransactionID", (object)TransactionID ?? DBNull.Value);

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
                clsErrorLogger.LogError(ex);

                isFound = false;
            }
            return isFound;
        }

        public static int GetTransactionIDByBookingID(int? BookingID)
        {
            int TransactionID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTransactionIDByBookingID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)BookingID ?? DBNull.Value);

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
                clsErrorLogger.LogError(ex);
                TransactionID = -1;
            }
            return TransactionID;

        }

        public static DataTable GetAllRentalTransactions()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllRentalTransactions", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Datatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }
            return Datatable;
        }

    }
}
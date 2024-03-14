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
            ref float PaidInitialTotalDueAmount, ref float ActualTotalDueAmount, 
            ref float TotalRemaining, ref float TotalRefundedAmount, 
            ref DateTime TransactionDate, ref DateTime? UpdatedTransactionDate)
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

                                ActualTotalDueAmount = (float)reader["ActualTotalDueAmount"];

                                TotalRemaining = (float)reader["TotalRemaining"];

                                TotalRefundedAmount = (float)reader["TotalRefundedAmount"];

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

        public static int? AddNewRentalTransaction(int BookingID, int? ReturnID,
            float PaidInitialTotalDueAmount, float ActualTotalDueAmount, 
            float TotalRemaining, float TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate)
        {
            int? TransactionID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewRentalTransaction", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@ReturnID", (object)ReturnID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
                        command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
                        command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                        command.Parameters.AddWithValue("@UpdatedTransactionDate", (object)UpdatedTransactionDate ?? DBNull.Value);


                        SqlParameter outputParameter = new SqlParameter("@NewTransactionID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputParameter);

                        command.ExecuteNonQuery();

                        TransactionID = (int)outputParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                TransactionID = null;
            }
            return TransactionID;
        }

        public static bool UpdateRentalTransactionInfo(int? TransactionID, int BookingID, int? ReturnID, 
            float PaidInitialTotalDueAmount, float ActualTotalDueAmount,
            float TotalRemaining, float TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateRentalTransactionInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TransactionID", TransactionID);
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@ReturnID", (object)ReturnID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
                        command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
                        command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                        command.Parameters.AddWithValue("@UpdatedTransactionDate", (object)UpdatedTransactionDate ?? DBNull.Value);


                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                rowsAffected = 0;
            }
            return rowsAffected != 0;
        }

        public static bool DeleteRentalTransaction(int? TransactionID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteRentalTransaction", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TransactionID", (object)TransactionID ?? DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }
            return rowsAffected != 0;
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
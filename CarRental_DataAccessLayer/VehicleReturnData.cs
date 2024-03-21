using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class VehicleReturnData
    {
        public static bool GetVehicleReturnInfoByID(int? ReturenID, ref DateTime ActualReturnDate,
            ref byte ActualRentalDays, ref short Mileage, ref short ConsumedMileage,
            ref string FinalCheckNotes, ref float AdditionalCharges, ref float ActualTotalDueAmount,
            ref int TransactionID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehicleReturnInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ReturenID", (object)ReturenID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                ActualReturnDate = (DateTime)reader["ActualReturnDate"];

                                ActualRentalDays = (byte)reader["ActualRentalDays"];

                                Mileage = (short)reader["Mileage"];

                                ConsumedMileage = (short)reader["ConsumedMileage"];

                                FinalCheckNotes = (reader["FinalCheckNotes"] != DBNull.Value) ? (string)reader["FinalCheckNotes"] : null;

                                AdditionalCharges = Convert.ToSingle(reader["AdditionalCharges"]);

                                ActualTotalDueAmount = Convert.ToSingle(reader["ActualTotalDueAmount"]);

                                TransactionID = (int)reader["TransactionID"];

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

        public static bool DoesVehicleReturnExist(int? ReturenID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfVehicleReturnExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ReturenID", (object)ReturenID ?? DBNull.Value);

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

        public static int? AddNewVehicleReturn(DateTime ActualReturnDate, byte ActualRentalDays,
            short Mileage, short ConsumedMileage, string FinalCheckNotes,
            float AdditionalCharges, float ActualTotalDueAmount, int TransactionID)
        {
            int? ReturenID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewVehicleReturn", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                        command.Parameters.AddWithValue("@Mileage", Mileage);
                        command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
                        command.Parameters.AddWithValue("@FinalCheckNotes", (object)FinalCheckNotes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TransactionID", TransactionID);


                        SqlParameter outputReturenIDParameter = new SqlParameter("@NewReturenID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputReturenIDParameter);

                        command.ExecuteNonQuery();

                        ReturenID = (int)outputReturenIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                ReturenID = null;
            }
            return ReturenID;
        }

        public static bool UpdateVehicleReturnInfo(int? ReturenID, DateTime ActualReturnDate,
            byte ActualRentalDays, short Mileage, short ConsumedMileage,
            string FinalCheckNotes, float AdditionalCharges, float ActualTotalDueAmount,
            int TransactionID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateVehicleReturnInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReturenID", ReturenID);
                        command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                        command.Parameters.AddWithValue("@Mileage", Mileage);
                        command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
                        command.Parameters.AddWithValue("@FinalCheckNotes", (object)FinalCheckNotes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TransactionID", TransactionID);


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

        public static DataTable GetAllVehicleReturns()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllVehicleReturns", connection))
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
using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class VehicleReturnData
    {
        public static bool GetVehicleReturnInfoByID(int? returnID, ref DateTime actualReturnDate,
                                                    ref byte actualRentalDays, ref short mileage, ref short consumedMileage,
                                                    ref string finalCheckNotes, ref float additionalCharges, ref float actualTotalDueAmount,
                                                    ref int transactionID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehicleReturnInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ReturenID", (object)returnID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                actualReturnDate = (DateTime)reader["ActualReturnDate"];

                                actualRentalDays = (byte)reader["ActualRentalDays"];

                                mileage = (short)reader["Mileage"];

                                consumedMileage = (short)reader["ConsumedMileage"];

                                finalCheckNotes = (reader["FinalCheckNotes"] != DBNull.Value) ? (string)reader["FinalCheckNotes"] : null;

                                additionalCharges = Convert.ToSingle(reader["AdditionalCharges"]);

                                actualTotalDueAmount = Convert.ToSingle(reader["ActualTotalDueAmount"]);

                                transactionID = (int)reader["TransactionID"];

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

        public static bool DoesVehicleReturnExist(int? returnID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfVehicleReturnExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ReturenID", (object)returnID ?? DBNull.Value);

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

        public static int? AddNewVehicleReturn(DateTime actualReturnDate, byte actualRentalDays,
                                               short mileage, short consumedMileage, string finalCheckNotes,
                                               float additionalCharges, float actualTotalDueAmount, int transactionID)
        {
            int? returnID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewVehicleReturn", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ActualReturnDate", actualReturnDate);
                        command.Parameters.AddWithValue("@ActualRentalDays", actualRentalDays);
                        command.Parameters.AddWithValue("@Mileage", mileage);
                        command.Parameters.AddWithValue("@ConsumedMileage", consumedMileage);
                        command.Parameters.AddWithValue("@FinalCheckNotes", (object)finalCheckNotes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdditionalCharges", additionalCharges);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", actualTotalDueAmount);
                        command.Parameters.AddWithValue("@TransactionID", transactionID);


                        SqlParameter outputReturenIDParameter = new SqlParameter("@NewReturenID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputReturenIDParameter);

                        command.ExecuteNonQuery();

                        returnID = (int)outputReturenIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                returnID = null;
            }
            return returnID;
        }

        public static bool UpdateVehicleReturnInfo(int? returnID, DateTime actualReturnDate,
                                                   byte actualRentalDays, short mileage, short consumedMileage,
                                                   string finalCheckNotes, float additionalCharges, float actualTotalDueAmount,
                                                   int transactionID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateVehicleReturnInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReturenID", returnID);
                        command.Parameters.AddWithValue("@ActualReturnDate", actualReturnDate);
                        command.Parameters.AddWithValue("@ActualRentalDays", actualRentalDays);
                        command.Parameters.AddWithValue("@Mileage", mileage);
                        command.Parameters.AddWithValue("@ConsumedMileage", consumedMileage);
                        command.Parameters.AddWithValue("@FinalCheckNotes", (object)finalCheckNotes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdditionalCharges", additionalCharges);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", actualTotalDueAmount);
                        command.Parameters.AddWithValue("@TransactionID", transactionID);


                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                rowsAffected = 0;
            }
            return rowsAffected != 0;
        }

        public static DataTable GetAllVehicleReturns()
        {
            DataTable vehicleReturnsDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllVehicleReturns", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                vehicleReturnsDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return vehicleReturnsDatatable;
        }

        public static DataTable GetAllVehicleReturnsByDateRange(DateTime startDate , DateTime endDate)
        {
            DataTable vehicleReturnsDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllVehicleReturnsByDateRange", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                vehicleReturnsDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return vehicleReturnsDatatable;
        }

        public static int GetTotalVehicleReturnsCount()
        {
            int totalvehicleReturnsCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehicleReturnsCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        totalvehicleReturnsCount = (int)returnValue.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                totalvehicleReturnsCount = 0;
            }
            return totalvehicleReturnsCount;
        }

    }
}
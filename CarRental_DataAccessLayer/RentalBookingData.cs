using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;
namespace CarRental_DataAccessLayer
{
    public class RentalBookingData
    {
        public static bool GetRentalBookingInfoByID(int? bookingID, ref int customerID, ref int vehicleID,
                                                    ref DateTime rentalStartDate, ref DateTime rentalEndDate,
                                                    ref string pickupLocation, ref string dropoffLocation,
                                                    ref int initialRentalDays, ref float rentalPricePerDay,
                                                    ref float initialTotalDueAmount, ref string initialCheckNotes)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalBookingInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)bookingID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                customerID = (int)reader["CustomerID"];

                                vehicleID = (int)reader["VehicleID"];

                                rentalStartDate = (DateTime)reader["RentalStartDate"];

                                rentalEndDate = (DateTime)reader["RentalEndDate"];

                                pickupLocation = (string)reader["PickupLocation"];

                                dropoffLocation = (string)reader["DropoffLocation"];

                                initialRentalDays = (int)reader["InitialRentalDays"];

                                rentalPricePerDay = Convert.ToSingle(reader["RentalPricePerDay"]);

                                initialTotalDueAmount = Convert.ToSingle(reader["InitialTotalDueAmount"]);

                                initialCheckNotes = (reader["InitialCheckNotes"] != DBNull.Value) ? (string)reader["InitialCheckNotes"] : null;

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

        public static bool GetRentalBookingInfoByTransactionID(int? transactionID , ref int? bookingID, ref int customerID, ref int vehicleID,
                                            ref DateTime rentalStartDate, ref DateTime rentalEndDate,
                                            ref string pickupLocation, ref string dropoffLocation,
                                            ref int initialRentalDays, ref float rentalPricePerDay,
                                            ref float initialTotalDueAmount, ref string initialCheckNotes)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalBookingInfoByTransactionID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TransactionID", (object)transactionID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                bookingID = (reader["BookingID"] != DBNull.Value) ? (int?)reader["BookingID"] : null;

                                customerID = (int)reader["CustomerID"];

                                vehicleID = (int)reader["VehicleID"];

                                rentalStartDate = (DateTime)reader["RentalStartDate"];

                                rentalEndDate = (DateTime)reader["RentalEndDate"];

                                pickupLocation = (string)reader["PickupLocation"];

                                dropoffLocation = (string)reader["DropoffLocation"];

                                initialRentalDays = (int)reader["InitialRentalDays"];

                                rentalPricePerDay = Convert.ToSingle(reader["RentalPricePerDay"]);

                                initialTotalDueAmount = Convert.ToSingle(reader["InitialTotalDueAmount"]);

                                initialCheckNotes = (reader["InitialCheckNotes"] != DBNull.Value) ? (string)reader["InitialCheckNotes"] : null;

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

        public static bool DoesRentalBookingExist(int? bookingID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfRentalBookingExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)bookingID ?? DBNull.Value);

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

        public static bool IsRentalBookingActive(int? bookingID)
        {
            bool isActive = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfRentalBookingIsActive", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)bookingID ?? DBNull.Value);

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        isActive = (int)returnValue.Value == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                isActive = false;
            }
            return isActive;
        }

        public static int? AddNewRentalBooking(int customerID, int vehicleID, DateTime rentalStartDate,
                                               DateTime rentalEndDate, string pickupLocation, string dropoffLocation,
                                               float rentalPricePerDay, string initialCheckNotes)
        {
            int? bookingID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewRentalBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@VehicleID", vehicleID);
                        command.Parameters.AddWithValue("@RentalStartDate", rentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", rentalEndDate);
                        command.Parameters.AddWithValue("@PickupLocation", pickupLocation);
                        command.Parameters.AddWithValue("@DropoffLocation", dropoffLocation);
                        command.Parameters.AddWithValue("@RentalPricePerDay", rentalPricePerDay);
                        command.Parameters.AddWithValue("@InitialCheckNotes", (object)initialCheckNotes ?? DBNull.Value);

                        SqlParameter outputParameter = new SqlParameter("@NewBookingID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputParameter);

                        command.ExecuteNonQuery();

                        bookingID = (int)outputParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                bookingID = null;
            }
            return bookingID;
        }

        public static bool UpdateRentalBookingInfo(int? bookingID, int customerID, int vehicleID,
                                                   DateTime rentalStartDate, DateTime rentalEndDate,
                                                   string pickupLocation, string dropoffLocation,
                                                   float rentalPricePerDay, string initialCheckNotes)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateRentalBookingInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookingID", bookingID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@VehicleID", vehicleID);
                        command.Parameters.AddWithValue("@RentalStartDate", rentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", rentalEndDate);
                        command.Parameters.AddWithValue("@PickupLocation", pickupLocation);
                        command.Parameters.AddWithValue("@DropoffLocation", dropoffLocation);
                        command.Parameters.AddWithValue("@RentalPricePerDay", rentalPricePerDay);
                        command.Parameters.AddWithValue("@InitialCheckNotes", (object)initialCheckNotes ?? DBNull.Value);

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

        public static DataTable GetAllRentalBookings()
        {
            DataTable rentalBookingsdatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllRentalBookings", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                rentalBookingsdatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return rentalBookingsdatatable;
        }

        public static DataTable GetAllRentalBookingsByDateRange(DateTime startDate , DateTime endDate)
        {
            DataTable rentalBookingsdatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllRentalBookingsByDateRange", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate",  endDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                rentalBookingsdatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return rentalBookingsdatatable;
        }

        public static int GetTotalRentalBookingsCount()
        {
            int totalRentalBookingsCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalBookingsCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        totalRentalBookingsCount = (int)returnValue.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                totalRentalBookingsCount = 0;
            }
            return totalRentalBookingsCount;
        }

    }
}
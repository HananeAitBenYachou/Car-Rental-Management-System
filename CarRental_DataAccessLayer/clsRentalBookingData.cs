using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;
namespace CarRental_DataAccessLayer
{
    public class clsRentalBookingData
    {
        public static bool GetRentalBookingInfoByID(int? BookingID, ref int CustomerID, ref int VehicleID, 
            ref DateTime RentalStartDate, ref DateTime RentalEndDate, ref string PickupLocation, 
            ref string DropoffLocation, ref int InitialRentalDays, ref float RentalPricePerDay, 
            ref float InitialTotalDueAmount, ref string InitialCheckNotes)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetRentalBookingInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)BookingID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                CustomerID = (int)reader["CustomerID"];

                                VehicleID = (int)reader["VehicleID"];

                                RentalStartDate = (DateTime)reader["RentalStartDate"];

                                RentalEndDate = (DateTime)reader["RentalEndDate"];

                                PickupLocation = (string)reader["PickupLocation"];

                                DropoffLocation = (string)reader["DropoffLocation"];

                                InitialRentalDays = (int)reader["InitialRentalDays"];

                                RentalPricePerDay = Convert.ToSingle(reader["RentalPricePerDay"]);

                                InitialTotalDueAmount = Convert.ToSingle(reader["InitialTotalDueAmount"]);

                                InitialCheckNotes = (reader["InitialCheckNotes"] != DBNull.Value) ? (string)reader["InitialCheckNotes"] : null;

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

        public static bool DoesRentalBookingExist(int? BookingID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfRentalBookingExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)BookingID ?? DBNull.Value);

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

        public static int? AddNewRentalBooking(int CustomerID, int VehicleID, DateTime RentalStartDate,
            DateTime RentalEndDate, string PickupLocation, string DropoffLocation,
            float RentalPricePerDay, string InitialCheckNotes)
        {
            int? BookingID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewRentalBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
                        command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
                        command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
                        command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        command.Parameters.AddWithValue("@InitialCheckNotes", (object)InitialCheckNotes ?? DBNull.Value);


                        SqlParameter outputParameter = new SqlParameter("@NewBookingID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputParameter);

                        command.ExecuteNonQuery();

                        BookingID = (int)outputParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                BookingID = null;
            }
            return BookingID;
        }

        public static bool UpdateRentalBookingInfo(int? BookingID, int CustomerID, int VehicleID,
            DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation,
            string DropoffLocation, float RentalPricePerDay,
            string InitialCheckNotes)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateRentalBookingInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
                        command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
                        command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
                        command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
                        command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        command.Parameters.AddWithValue("@InitialCheckNotes", (object)InitialCheckNotes ?? DBNull.Value);


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

        public static bool DeleteRentalBooking(int? BookingID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteRentalBooking", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookingID", (object)BookingID ?? DBNull.Value);

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

        public static DataTable GetAllRentalBookings()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllRentalBookings", connection))
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
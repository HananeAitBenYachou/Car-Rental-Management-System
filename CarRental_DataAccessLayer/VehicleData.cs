using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class VehicleData
    {
        public static bool GetVehicleInfoByID(int? vehicleID, ref int makeID, ref int modelID,
                                              ref int subModelID, ref string vehicleName, ref short year, ref int driveTypeID,
                                              ref string engine, ref int fuelTypeID, ref byte numDoors, ref int mileage,
                                              ref double rentalPricePerDay, ref bool isAvailableForRent)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehicleInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)vehicleID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                makeID = (int)reader["MakeID"];

                                modelID = (int)reader["ModelID"];

                                subModelID = (int)reader["SubModelID"];

                                vehicleName = (string)reader["VehicleName"];

                                year = (short)reader["Year"];

                                driveTypeID = (int)reader["DriveTypeID"];

                                engine = (reader["Engine"] != DBNull.Value) ? (string)reader["Engine"] : null;

                                fuelTypeID = (int)reader["FuelTypeID"];

                                numDoors = (byte)reader["NumDoors"];

                                mileage = (int)reader["Mileage"];

                                rentalPricePerDay = Convert.ToDouble(reader["RentalPricePerDay"]);

                                isAvailableForRent = (bool)reader["IsAvailableForRent"];

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

        public static bool DoesVehicleExist(int? vehicleID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfVehicleExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)vehicleID ?? DBNull.Value);

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

        public static int? AddNewVehicle(int makeID, int modelID, int subModelID, string vehicleName,
                                         short year, int driveTypeID, string engine, int fuelTypeID, byte numDoors, int mileage,
                                         double rentalPricePerDay, bool isAvailableForRent)
        {
            int? vehicleID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewVehicle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MakeID", makeID);
                        command.Parameters.AddWithValue("@ModelID", modelID);
                        command.Parameters.AddWithValue("@SubModelID", subModelID);
                        command.Parameters.AddWithValue("@VehicleName", vehicleName);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@DriveTypeID", driveTypeID);
                        command.Parameters.AddWithValue("@Engine", (object)engine ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                        command.Parameters.AddWithValue("@NumDoors", numDoors);
                        command.Parameters.AddWithValue("@Mileage", mileage);
                        command.Parameters.AddWithValue("@RentalPricePerDay", rentalPricePerDay);
                        command.Parameters.AddWithValue("@IsAvailableForRent", isAvailableForRent);


                        SqlParameter outputVehicleIDParameter = new SqlParameter("@NewVehicleID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputVehicleIDParameter);

                        command.ExecuteNonQuery();

                        vehicleID = (int)outputVehicleIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                vehicleID = null;
            }
            return vehicleID;
        }

        public static bool UpdateVehicleInfo(int? vehicleID, int makeID, int modelID, int subModelID,
                                             string vehicleName, short year, int driveTypeID, string engine, int fuelTypeID,
                                             byte numDoors, int mileage, double rentalPricePerDay, bool isAvailableForRent)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateVehicleInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@VehicleID", vehicleID);
                        command.Parameters.AddWithValue("@MakeID", makeID);
                        command.Parameters.AddWithValue("@ModelID", modelID);
                        command.Parameters.AddWithValue("@SubModelID", subModelID);
                        command.Parameters.AddWithValue("@VehicleName", vehicleName);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@DriveTypeID", driveTypeID);
                        command.Parameters.AddWithValue("@Engine", (object)engine ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                        command.Parameters.AddWithValue("@NumDoors", numDoors);
                        command.Parameters.AddWithValue("@Mileage", mileage);
                        command.Parameters.AddWithValue("@RentalPricePerDay", rentalPricePerDay);
                        command.Parameters.AddWithValue("@IsAvailableForRent", isAvailableForRent);

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

        public static bool DeleteVehicle(int? vehicleID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteVehicle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)vehicleID ?? DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return rowsAffected != 0;
        }

        public static DataTable GetVehiclesPaginated(int pageNumber, int rowsPerPage)
        {
            DataTable vehiclesDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehiclesByPage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PageNumber", pageNumber);
                        command.Parameters.AddWithValue("@RowsPerPage", rowsPerPage);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                vehiclesDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return vehiclesDatatable;
        }

        public static DataTable GetAllVehicles()
        {
            DataTable vehiclesDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllVehicles", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                vehiclesDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return vehiclesDatatable;
        }

        public static int GetTotalVehiclesCount()
        {
            int totalvehiclesCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTotalVehiclesCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        totalvehiclesCount = (int)returnValue.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                totalvehiclesCount = 0;
            }
            return totalvehiclesCount;
        }

        public static int GetVehiclesCountPerStatus(bool vehicleStatus)
        {
            int vehiclesCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehiclesCountPerStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Status", vehicleStatus); 

                        SqlParameter returnValue = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        vehiclesCount = (int)returnValue.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                vehiclesCount = 0;
            }
            return vehiclesCount;
        }

        public static List<(int vehicleId, string vehicleName, int rank)> GetTopMostRentedVehicles()
        {
            var vehiclesList = new List<(int vehicleId, string vehicleName, int rank)>();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTopMostRentedVehicles", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int vehicleID = 0;
                            string vehicleName = "";
                            int rank = 0;

                            while(reader.Read())
                            {
                                vehicleID = (int)reader["Vehicle ID"];
                                vehicleName = (string)reader["Vehicle Name"];
                                rank = (int)(long)(reader["Rank"]);

                                vehiclesList.Add((vehicleID, vehicleName, rank));
                            }                     
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return vehiclesList;
        }

        public static DataTable GetVehicleMaintenances(int? vehicleID)
        {
            DataTable vehicleMaintenancesDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehicleMaintenances", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)vehicleID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                vehicleMaintenancesDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return vehicleMaintenancesDatatable;
        }

        public static DataTable GetVehicleRentalBookings(int? vehicleID)
        {
            DataTable vehicleRentalBookingsDatatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehicleRentalBookings", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)vehicleID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                vehicleRentalBookingsDatatable.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
            }
            return vehicleRentalBookingsDatatable;
        }

    }

}
using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class clsVehicleData
    {
        public static bool GetVehicleInfoByID(int? VehicleID, ref int MakeID, ref int ModelID, 
            ref int SubModelID, ref string VehicleName, ref short Year, ref int DriveTypeID,
            ref string Engine, ref int FuelTypeID, ref byte NumDoors, ref int Mileage, 
            ref double RentalPricePerDay, ref bool IsAvailableForRent)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetVehicleInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)VehicleID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                MakeID = (int)reader["MakeID"];

                                ModelID = (int)reader["ModelID"];

                                SubModelID = (int)reader["SubModelID"];

                                VehicleName = (string)reader["VehicleName"];

                                Year = (short)reader["Year"];

                                DriveTypeID = (int)reader["DriveTypeID"];

                                Engine = (reader["Engine"] != DBNull.Value) ? (string)reader["Engine"] : null;

                                FuelTypeID = (int)reader["FuelTypeID"];

                                NumDoors = (byte)reader["NumDoors"];

                                Mileage = (int)reader["Mileage"];

                                RentalPricePerDay = Convert.ToDouble(reader["RentalPricePerDay"]);

                                IsAvailableForRent = (bool)reader["IsAvailableForRent"];

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

        public static bool DoesVehicleExist(int? VehicleID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfVehicleExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)VehicleID ?? DBNull.Value);

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

        public static int? AddNewVehicle(int MakeID, int ModelID, int SubModelID, string VehicleName,
            short Year, int DriveTypeID, string Engine, int FuelTypeID, byte NumDoors, int Mileage,
            double RentalPricePerDay, bool IsAvailableForRent)
        {
            int? VehicleID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewVehicle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MakeID", MakeID);
                        command.Parameters.AddWithValue("@ModelID", ModelID);
                        command.Parameters.AddWithValue("@SubModelID", SubModelID);
                        command.Parameters.AddWithValue("@VehicleName", VehicleName);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@DriveTypeID", DriveTypeID);
                        command.Parameters.AddWithValue("@Engine", (object)Engine ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        command.Parameters.AddWithValue("@NumDoors", NumDoors);
                        command.Parameters.AddWithValue("@Mileage", Mileage);
                        command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);


                        SqlParameter outputVehicleIDParameter = new SqlParameter("@NewVehicleID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputVehicleIDParameter);

                        command.ExecuteNonQuery();

                        VehicleID = (int)outputVehicleIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                VehicleID = null;
            }
            return VehicleID;
        }

        public static bool UpdateVehicleInfo(int? VehicleID, int MakeID, int ModelID, int SubModelID,
            string VehicleName, short Year, int DriveTypeID, string Engine, int FuelTypeID,
            byte NumDoors, int Mileage,double RentalPricePerDay, bool IsAvailableForRent)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateVehicleInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@MakeID", MakeID);
                        command.Parameters.AddWithValue("@ModelID", ModelID);
                        command.Parameters.AddWithValue("@SubModelID", SubModelID);
                        command.Parameters.AddWithValue("@VehicleName", VehicleName);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@DriveTypeID", DriveTypeID);
                        command.Parameters.AddWithValue("@Engine", (object)Engine ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        command.Parameters.AddWithValue("@NumDoors", NumDoors);
                        command.Parameters.AddWithValue("@Mileage", Mileage);
                        command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                        command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

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

        public static bool DeleteVehicle(int? VehicleID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteVehicle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", (object)VehicleID ?? DBNull.Value);

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

        public static DataTable GetAllVehicles(int PageNumber , int RowsPerPage)
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllVehicles", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);

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

        public static int GetTotalVehiclesCount()
        {
            int TotalCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
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

                        TotalCount = (int)returnValue.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                TotalCount = 0;
            }
            return TotalCount;
        }

    }

}
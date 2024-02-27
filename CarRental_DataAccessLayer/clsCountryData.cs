using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int? CountryID, ref string CountryName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetCountryInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                CountryName = (string)reader["CountryName"];

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

        public static bool DoesCountryExist(int? CountryID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfCountryExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

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

        public static int? AddNewCountry(string CountryName)
        {
            int? CountryID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewCountry", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CountryName", CountryName);


                        SqlParameter outputContactIDParameter = new SqlParameter("@CountryID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputContactIDParameter);

                        command.ExecuteNonQuery();

                        CountryID = (int)outputContactIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                CountryID = null;
            }
            return CountryID;
        }

        public static bool UpdateCountryInfo(int? CountryID, string CountryName)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateCountryInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        command.Parameters.AddWithValue("@CountryName", CountryName);


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

        public static bool DeleteCountry(int? CountryID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteCountry", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

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

        public static DataTable GetAllCountries()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllCountries", connection))
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
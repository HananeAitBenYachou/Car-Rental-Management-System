using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class clsSubModelData
    {
        public static bool GetSubModelInfoByID(int? SubModelID, ref int ModelID, ref string SubModelName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubModelInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubModelID", (object)SubModelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                ModelID = (int)reader["ModelID"];

                                SubModelName = (string)reader["SubModelName"];

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

        public static bool DoesSubModelExist(int? SubModelID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfSubModelExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubModelID", (object)SubModelID ?? DBNull.Value);

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

        public static int? AddNewSubModel(int ModelID, string SubModelName)
        {
            int? SubModelID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewSubModel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ModelID", ModelID);
                        command.Parameters.AddWithValue("@SubModelName", SubModelName);


                        SqlParameter outputContactIDParameter = new SqlParameter("@SubModelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputContactIDParameter);

                        command.ExecuteNonQuery();

                        SubModelID = (int)outputContactIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                SubModelID = null;
            }
            return SubModelID;
        }

        public static bool UpdateSubModelInfo(int? SubModelID, int ModelID, string SubModelName)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateSubModelInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SubModelID", SubModelID);
                        command.Parameters.AddWithValue("@ModelID", ModelID);
                        command.Parameters.AddWithValue("@SubModelName", SubModelName);


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

        public static bool DeleteSubModel(int? SubModelID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteSubModel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubModelID", (object)SubModelID ?? DBNull.Value);

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

        public static DataTable GetAllSubModels()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllSubModels", connection))
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
using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class clsUserData
    {
        public static bool GetUserInfoByID(int? UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                PersonID = (int)reader["PersonID"];

                                UserName = (string)reader["UserName"];

                                Password = (string)reader["Password"];

                                IsActive = (bool)reader["IsActive"];

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

        public static bool DoesUserExist(int? UserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfUserExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

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

        public static int? AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int? UserID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);


                        SqlParameter outputContactIDParameter = new SqlParameter("@UserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputContactIDParameter);

                        command.ExecuteNonQuery();

                        UserID = (int)outputContactIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);

                UserID = null;
            }
            return UserID;
        }

        public static bool UpdateUserInfo(int? UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateUserInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);


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

        public static bool DeleteUser(int? UserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

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

        public static DataTable GetAllUsers()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
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

        public static int? GetUserPersonID(int? UserID)
        {
            int? PersonID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

                        SqlParameter outputPersonIDParameter = new SqlParameter("@PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputPersonIDParameter);

                        command.ExecuteNonQuery();

                        PersonID = (int)outputPersonIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                PersonID = null;
            }
            return PersonID;
        }
    }
}
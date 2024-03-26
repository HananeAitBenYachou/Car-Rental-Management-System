using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class PersonData
    {
        public static bool GetPersonInfoByID(int? personID, ref string nationalNo, ref string firstName,
                                             ref string lastName, ref DateTime birthDate, ref byte gender,
                                             ref string address, ref string phone, ref string email,
                                             ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                nationalNo = (string)reader["NationalNo"];

                                firstName = (string)reader["FirstName"];

                                lastName = (string)reader["LastName"];

                                birthDate = (DateTime)reader["BirthDate"];

                                gender = (byte)reader["Gender"];

                                address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                phone = (string)reader["Phone"];

                                email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null;

                                nationalityCountryID = (int)reader["NationalityCountryID"];

                                imagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;

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

        public static bool GetPersonInfoByNationalNo(string nationalNo, ref int? personID, ref string firstName,
                                                     ref string lastName, ref DateTime birthDate, ref byte gender,
                                                     ref string address, ref string phone, ref string email,
                                                     ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo", nationalNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;

                                firstName = (string)reader["FirstName"];

                                lastName = (string)reader["LastName"];

                                birthDate = (DateTime)reader["BirthDate"];

                                gender = (byte)reader["Gender"];

                                address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                phone = (string)reader["Phone"];

                                email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null;

                                nationalityCountryID = (int)reader["NationalityCountryID"];

                                imagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;

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
        public static bool DoesPersonExist(int? personID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfPersonExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

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

        public static bool DoesPersonExist(string nationalNo)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfPersonExistsByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@NationalNo", nationalNo);

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

        public static int? AddNewPerson(string nationalNo, string firstName, string lastName, DateTime birthDate,
                                        byte gender, string address, string phone, string email,
                                        int nationalityCountryID, string imagePath)
        {
            int? personID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNo", nationalNo);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", (object)address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);


                        SqlParameter outputPersonIDParameter = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputPersonIDParameter);

                        command.ExecuteNonQuery();

                        personID = (int)outputPersonIDParameter.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);

                personID = null;
            }
            return personID;
        }

        public static bool UpdatePersonInfo(int? personID, string nationalNo, string firstName, string lastName,
                                            DateTime birthDate, byte gender, string address, string phone, string email,
                                            int nationalityCountryID, string imagePath)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePersonInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@NationalNo", nationalNo);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", (object)address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);


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

        public static bool DeletePerson(int? personID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

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

    }
}
using CarRental_DataAccessLayer.GlobalClasses;
using CarRental_UtilityLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int? PersonID, ref string NationalNo, ref string FirstName, ref string LastName, ref DateTime BirthDate, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                isFound = true;

                                NationalNo = (string)reader["NationalNo"];

                                FirstName = (string)reader["FirstName"];

                                LastName = (string)reader["LastName"];

                                BirthDate = (DateTime)reader["BirthDate"];

                                Gender = (byte)reader["Gender"];

                                Address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                Phone = (string)reader["Phone"];

                                Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null;

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;

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

        public static bool DoesPersonExist(int? PersonID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_CheckIfPersonExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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

        public static int? AddNewPerson(string NationalNo, string FirstName, string LastName, DateTime BirthDate, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int? PersonID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);


                        SqlParameter outputContactIDParameter = new SqlParameter("@PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputContactIDParameter);

                        command.ExecuteNonQuery();

                        PersonID = (int)outputContactIDParameter.Value;
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

        public static bool UpdatePersonInfo(int? PersonID, string NationalNo, string FirstName, string LastName, DateTime BirthDate, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePersonInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);


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

        public static bool DeletePerson(int? PersonID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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

        public static DataTable GetAllPeople()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
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
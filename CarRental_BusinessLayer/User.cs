using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class User : Person
    {
        private new enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode;

        public enum EnFindUserBy : byte { PersonID = 0, UserID = 1, UserName = 3 }

        public int? UserID { get; private set; }
        public new int? PersonID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public User() : base()
        {
            _mode = EnMode.AddNew;

            UserID = null;
            PersonID = null;
            UserName = default;
            Password = default;
            IsActive = default;
        }
        private User(int? userID, int? personID, string userName, string password, bool isActive, string nationalNo,
                     string firstName, string lastName, DateTime birthDate, EnGender gender, string address,
                     string phone, string email, int nationalityCountryID, string imagePath)

                    : base(personID, nationalNo, firstName, lastName, birthDate, gender, address, phone, email,
                           nationalityCountryID, imagePath)

        {
            _mode = EnMode.Update;

            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = Password;
            IsActive = isActive;
        }

        private static User FindUserByUserID(int? userID)
        {
            int? personID = default;
            string userName = default;
            string password = default;
            bool isActive = default;

            bool isFound = UserData.GetUserInfoByID(userID, ref personID, ref userName, ref password, ref isActive);

            if (isFound)
            {
                Person person = Person.Find(personID);

                if (person == null)
                    return null;

                return new User(userID, personID, userName, password, isActive, person.NationalNo, person.FirstName,
                                person.LastName, person.BirthDate, person.Gender, person.Address, person.Phone,
                                person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        private static User FindUserByPersonID(int? personID)
        {
            int? userID = default;
            string userName = default;
            string password = default;
            bool isActive = default;

            bool isFound = UserData.GetUserInfoByPersonID(personID, ref userID, ref userName, ref password, ref isActive);

            if (isFound)
            {
                Person person = Person.Find(personID);

                if (person == null)
                    return null;

                return new User(userID, personID, userName, password, isActive, person.NationalNo, person.FirstName,
                                person.LastName, person.BirthDate, person.Gender, person.Address, person.Phone,
                                person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        private static User FindUserByUserName(string userName)
        {
            int? personID = default;
            int? userID = default;
            string password = default;
            bool isActive = default;

            bool isFound = UserData.GetUserInfoByUserName(userName, ref userID, ref personID, ref password, ref isActive);

            if (isFound)
            {
                Person person = Person.Find(personID);

                if (person == null)
                    return null;

                return new User(userID, personID, userName, password, isActive, person.NationalNo, person.FirstName,
                                person.LastName, person.BirthDate, person.Gender, person.Address, person.Phone,
                                person.Email, person.NationalityCountryID, person.ImagePath);
            }
            else
                return null;
        }

        public static User Find(string userName, string password)
        {
            int? personID = default;
            int? userID = default;
            bool isActive = default;

            bool isFound = UserData.GetUserInfoByUserNameAndPassword(userName, password, ref userID, ref personID, ref isActive);

            if (isFound)
            {
                Person person = Person.Find(personID);

                if (person == null)
                    return null;

                return new User(userID, personID, userName, password, isActive, person.NationalNo, person.FirstName,
                                person.LastName, person.BirthDate, person.Gender, person.Address, person.Phone,
                                person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        public static User Find<T>(T searchValue, EnFindUserBy findUserBy)
        {
            switch (findUserBy)
            {
                case EnFindUserBy.PersonID:
                    return FindUserByPersonID(Convert.ToInt32(searchValue));

                case EnFindUserBy.UserID:
                    return FindUserByUserID(Convert.ToInt32(searchValue));

                case EnFindUserBy.UserName:
                    return FindUserByUserName(Convert.ToString(searchValue));

                default:
                    return null;
            }
        }

        public static bool DoesUserExist(int? userID)
        {
            return UserData.DoesUserExist(userID);
        }

        public static bool DoesUserExist(string userName)
        {
            return UserData.DoesUserExist(userName);
        }

        private bool AddNewUser()
        {
            UserID = UserData.AddNewUser(PersonID, UserName, Password, IsActive);
            return UserID.HasValue;
        }

        private bool UpdateUser()
        {
            return UserData.UpdateUserInfo(UserID, PersonID, UserName, Password, IsActive);
        }

        public new bool Save()
        {
            if (!base.Save())
                return false;

            PersonID = base.PersonID;

            switch (_mode)
            {
                case EnMode.AddNew:
                    if (AddNewUser())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateUser();

            }
            return false;
        }

        public static bool DeleteUser(int? userID)
        {
            int? personID = UserData.GetUserPersonID(userID);

            if (!personID.HasValue)
                return false;

            return DeletePerson(personID) ? UserData.DeleteUser(userID) : false;
        }

        public static DataTable GetAllUsers()
        {
            return UserData.GetAllUsers();
        }

        public bool UpdateUserPassword(string newPassword)
        {
            return UserData.UpdateUserPassword(UserID, newPassword);
        }

        public static int GetTotalUsersCount()
        {
            return UserData.GetTotalUsersCount();
        }
    }
}
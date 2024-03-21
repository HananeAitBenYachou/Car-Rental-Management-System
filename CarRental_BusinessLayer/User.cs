using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class User : Person
    {
        private new enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public enum enFindUserBy : byte { PersonID = 0, UserID = 1, UserName = 3 }

        public int? UserID { get; private set; }
        public new int? PersonID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public User() : base()
        {
            _Mode = enMode.AddNew;
            UserID = null;
            PersonID = null;
            UserName = default;
            Password = default;
            IsActive = default;
        }
        private User(int? UserID, int? PersonID, string UserName, string Password, bool IsActive,
            string NationalNo, string FirstName, string LastName, DateTime BirthDate, enGender Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
            : base(PersonID, NationalNo, FirstName, LastName, BirthDate, Gender, Address, Phone, Email,
                  NationalityCountryID, ImagePath)

        {
            _Mode = enMode.Update;

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
        }

        private static User _FindUserByUserID(int? UserID)
        {
            int? PersonID = default;
            string UserName = default;
            string Password = default;
            bool IsActive = default;

            bool isFound = UserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (isFound)
            {
                Person person = Person.Find(PersonID);

                if (person == null)
                    return null;

                return new User(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        private static User _FindUserByPersonID(int? PersonID)
        {
            int? UserID = default;
            string UserName = default;
            string Password = default;
            bool IsActive = default;

            bool isFound = UserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (isFound)
            {
                Person person = Person.Find(PersonID);

                if (person == null)
                    return null;

                return new User(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        private static User _FindUserByUserName(string UserName)
        {
            int? PersonID = default;
            int? UserID = default;
            string Password = default;
            bool IsActive = default;

            bool isFound = UserData.GetUserInfoByUserName(UserName, ref UserID, ref PersonID, ref Password, ref IsActive);

            if (isFound)
            {
                Person person = Person.Find(PersonID);

                if (person == null)
                    return null;

                return new User(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        public static User Find(string UserName, string Password)
        {
            int? PersonID = default;
            int? UserID = default;
            bool IsActive = default;

            bool isFound = UserData.GetUserInfoByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (isFound)
            {
                Person person = Person.Find(PersonID);

                if (person == null)
                    return null;

                return new User(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        public static User Find<T>(T searchValue, enFindUserBy FindUserBy)
        {
            switch (FindUserBy)
            {
                case enFindUserBy.PersonID:
                    return _FindUserByPersonID(Convert.ToInt32(searchValue));

                case enFindUserBy.UserID:
                    return _FindUserByUserID(Convert.ToInt32(searchValue));

                case enFindUserBy.UserName:
                    return _FindUserByUserName(Convert.ToString(searchValue));

                default:
                    return null;
            }
        }

        public static bool DoesUserExist(int? UserID)
        {
            return UserData.DoesUserExist(UserID);
        }

        public static bool DoesUserExist(string UserName)
        {
            return UserData.DoesUserExist(UserName);
        }

        private bool _AddNewUser()
        {
            UserID = UserData.AddNewUser(PersonID, UserName, Password, IsActive);
            return UserID.HasValue;
        }

        private bool _UpdateUser()
        {
            return UserData.UpdateUserInfo(UserID, PersonID, UserName, Password, IsActive);
        }

        public new bool Save()
        {
            if (!base.Save())
                return false;

            this.PersonID = base.PersonID;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();

            }
            return false;
        }

        public static bool DeleteUser(int? UserID)
        {
            int? personID = UserData.GetUserPersonID(UserID);

            if (!personID.HasValue)
                return false;

            return Person.DeletePerson(personID) ? UserData.DeleteUser(UserID) : false;
        }

        public static DataTable GetAllUsers()
        {
            return UserData.GetAllUsers();
        }

        public bool UpdateUserPassword(string NewPassword)
        {
            return UserData.UpdateUserPassword(this.UserID, NewPassword);
        }
    }
}
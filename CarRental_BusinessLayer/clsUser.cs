using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsUser : clsPerson
    {
        private new enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public enum enFindUserBy { PersonID = 0, UserID = 1, UserName = 3}
        public int? UserID { get; private set; }
        public new int? PersonID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser() : base()
        {
            _Mode = enMode.AddNew;
            UserID = null;
            PersonID = null;
            UserName = default;
            Password = default;
            IsActive = default;
        }
        private clsUser(int? UserID, int? PersonID, string UserName, string Password, bool IsActive,
            string NationalNo, string FirstName, string LastName, DateTime BirthDate, enGender Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath) 
        {
            _Mode = enMode.Update;

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            base.NationalNo = NationalNo;
            base.FirstName = FirstName;
            base.LastName = LastName;
            base.BirthDate = BirthDate;
            base.Gender = Gender;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.NationalityCountryID = NationalityCountryID;
            base.ImagePath = ImagePath;
            base.CountryInfo = clsCountry.Find(NationalityCountryID);
        }

        private static clsUser _FindUserByUserID(int? UserID)
        {
            int? PersonID = default;
            string UserName = default;
            string Password = default;
            bool IsActive = default;

            bool isFound = clsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(PersonID);

                if (person == null)
                    return null;

                return new clsUser(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone,person.Email,person.NationalityCountryID,person.ImagePath);

            }
            else
                return null;
        }

        private static clsUser _FindUserByPersonID(int? PersonID)
        {
            int? UserID = default;
            string UserName = default;
            string Password = default;
            bool IsActive = default;

            bool isFound = clsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(PersonID);

                if (person == null)
                    return null;

                return new clsUser(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        private static clsUser _FindUserByUserName(string UserName)
        {
            int? PersonID = default;
            int? UserID = default;
            string Password = default;
            bool IsActive = default;

            bool isFound = clsUserData.GetUserInfoByUserName(UserName ,ref UserID, ref PersonID, ref Password, ref IsActive);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(PersonID);

                if (person == null)
                    return null;

                return new clsUser(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        public static clsUser Find(string UserName , string Password)
        {
            int? PersonID = default;
            int? UserID = default;
            bool IsActive = default;

            bool isFound = clsUserData.GetUserInfoByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (isFound)
            {
                clsPerson person = clsPerson.Find(PersonID);

                if (person == null)
                    return null;

                return new clsUser(UserID, PersonID, UserName, Password, IsActive,
                    person.NationalNo, person.FirstName, person.LastName, person.BirthDate, person.Gender, person.Address,
                    person.Phone, person.Email, person.NationalityCountryID, person.ImagePath);

            }
            else
                return null;
        }

        public static clsUser Find<T>(T searchValue , enFindUserBy FindUserBy)
        {
            switch(FindUserBy)
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
            return clsUserData.DoesUserExist(UserID);
        }

        public static bool DoesUserExist(string UserName)
        {
            return clsUserData.DoesUserExist(UserName);
        }

        private bool _AddNewUser()
        {
            UserID = clsUserData.AddNewUser(PersonID, UserName, Password, IsActive);
            return UserID.HasValue;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUserInfo(UserID, PersonID, UserName, Password, IsActive);
        }

        public new bool Save()
        {
            base.Mode = this.Mode;

            if (!base.Save())
                return false;
            else
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
            int? personID = clsUserData.GetUserPersonID(UserID);

            if (!personID.HasValue)
                return false;

            return clsPerson.DeletePerson(personID) ? clsUserData.DeleteUser(UserID) : false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public bool UpdateUserPassword(string NewPassword)
        {
            return clsUserData.UpdateUserPassword(this.UserID, NewPassword);
        }
    }
}
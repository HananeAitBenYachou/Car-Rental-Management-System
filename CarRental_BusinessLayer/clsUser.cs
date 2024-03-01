using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsUser : clsPerson
    {
        private new enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? UserID { get; private set; }
        public new int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser() : base()
        {
            _Mode = enMode.AddNew;
            UserID = null;
            PersonID = default;
            UserName = default;
            Password = default;
            IsActive = default;
        }
        private clsUser(int? UserID, int PersonID, string UserName, string Password, bool IsActive,
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
        }

        public static new clsUser Find(int? UserID)
        {
            int PersonID = default;
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

        public static bool DoesUserExist(int? UserID)
        {
            return clsUserData.DoesUserExist(UserID);
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

    }
}
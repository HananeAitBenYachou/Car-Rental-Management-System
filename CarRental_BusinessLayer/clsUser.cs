using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? UserID { get; private set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            _Mode = enMode.AddNew;
            UserID = null;
            PersonID = default;
            UserName = default;
            Password = default;
            IsActive = default;
        }
        private clsUser(int? UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            _Mode = enMode.Update;
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
        }

        public static clsUser Find(int? UserID)
        {
            int PersonID = default;
            string UserName = default;
            string Password = default;
            bool IsActive = default;

            bool isFound = clsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (isFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
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

        public bool Save()
        {
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
            return clsUserData.DeleteUser(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

    }
}
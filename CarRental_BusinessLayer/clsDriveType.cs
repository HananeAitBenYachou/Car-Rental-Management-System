using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsDriveType
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? DriveTypeID { get; private set; }
        public string DriveTypeName { get; set; }

        public clsDriveType()
        {
            _Mode = enMode.AddNew;
            DriveTypeID = null;
            DriveTypeName = default;
        }
        private clsDriveType(int? DriveTypeID, string DriveTypeName)
        {
            _Mode = enMode.Update;
            this.DriveTypeID = DriveTypeID;
            this.DriveTypeName = DriveTypeName;
        }

        public static clsDriveType Find(int? DriveTypeID)
        {
            string DriveTypeName = default;

            bool isFound = clsDriveTypeData.GetDriveTypeInfoByID(DriveTypeID, ref DriveTypeName);

            if (isFound)
                return new clsDriveType(DriveTypeID, DriveTypeName);
            else
                return null;
        }

        public static bool DoesDriveTypeExist(int? DriveTypeID)
        {
            return clsDriveTypeData.DoesDriveTypeExist(DriveTypeID);
        }

        private bool _AddNewDriveType()
        {
            DriveTypeID = clsDriveTypeData.AddNewDriveType(DriveTypeName);
            return DriveTypeID.HasValue;
        }

        private bool _UpdateDriveType()
        {
            return clsDriveTypeData.UpdateDriveTypeInfo(DriveTypeID, DriveTypeName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriveType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateDriveType();

            }
            return false;
        }

        public static bool DeleteDriveType(int? DriveTypeID)
        {
            return clsDriveTypeData.DeleteDriveType(DriveTypeID);
        }

        public static DataTable GetAllDriveTypes()
        {
            return clsDriveTypeData.GetAllDriveTypes();
        }

    }
}
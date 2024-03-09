using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsDriveType
    {
        public int? DriveTypeID { get; private set; }
        public string DriveTypeName { get; set; }

        private clsDriveType(int? DriveTypeID, string DriveTypeName)
        {
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

        public static clsDriveType Find(string DriveTypeName)
        {
            int? DriveTypeID = default;

            bool isFound = clsDriveTypeData.GetDriveTypeInfoByName(DriveTypeName, ref DriveTypeID);

            if (isFound)
                return new clsDriveType(DriveTypeID, DriveTypeName);
            else
                return null;
        }

        public static DataTable GetAllDriveTypes()
        {
            return clsDriveTypeData.GetAllDriveTypes();
        }

    }
}
using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class DriveType
    {
        public int? DriveTypeID { get; private set; }
        public string DriveTypeName { get; set; }

        private DriveType(int? driveTypeID, string driveTypeName)
        {
            DriveTypeID = driveTypeID;
            DriveTypeName = driveTypeName;
        }

        public static DriveType Find(int? driveTypeID)
        {
            string driveTypeName = default;

            bool isFound = DriveTypeData.GetDriveTypeInfoByID(driveTypeID, ref driveTypeName);

            return isFound ? new DriveType(driveTypeID, driveTypeName) : null;
        }

        public static DriveType Find(string driveTypeName)
        {
            int? driveTypeID = default;

            bool isFound = DriveTypeData.GetDriveTypeInfoByName(driveTypeName, ref driveTypeID);

            return isFound ? new DriveType(driveTypeID, driveTypeName) : null;
        }

        public static DataTable GetAllDriveTypes()
        {
            return DriveTypeData.GetAllDriveTypes();
        }

    }
}
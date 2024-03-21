using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class DriveType
    {
        public int? DriveTypeID { get; private set; }
        public string DriveTypeName { get; set; }

        private DriveType(int? DriveTypeID, string DriveTypeName)
        {
            this.DriveTypeID = DriveTypeID;
            this.DriveTypeName = DriveTypeName;
        }

        public static DriveType Find(int? DriveTypeID)
        {
            string DriveTypeName = default;

            bool isFound = DriveTypeData.GetDriveTypeInfoByID(DriveTypeID, ref DriveTypeName);

            return isFound ? new DriveType(DriveTypeID, DriveTypeName) : null;
        }

        public static DriveType Find(string DriveTypeName)
        {
            int? DriveTypeID = default;

            bool isFound = DriveTypeData.GetDriveTypeInfoByName(DriveTypeName, ref DriveTypeID);

            return isFound ? new DriveType(DriveTypeID, DriveTypeName) : null;
        }

        public static DataTable GetAllDriveTypes()
        {
            return DriveTypeData.GetAllDriveTypes();
        }

    }
}
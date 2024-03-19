using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsFuelType
    {
        public int? FuelTypeID { get; private set; }
        public string FuelTypeName { get; set; }
     
        private clsFuelType(int? FuelTypeID, string FuelTypeName)
        {
            this.FuelTypeID = FuelTypeID;
            this.FuelTypeName = FuelTypeName;
        }

        public static clsFuelType Find(int? FuelTypeID)
        {
            string FuelTypeName = default;

            bool isFound = clsFuelTypeData.GetFuelTypeInfoByID(FuelTypeID, ref FuelTypeName);

            return isFound ? new clsFuelType(FuelTypeID, FuelTypeName) : null;
        }

        public static clsFuelType Find(string FuelTypeName)
        {
            int? FuelTypeID = default;

            bool isFound = clsFuelTypeData.GetFuelTypeInfoByName(FuelTypeName ,ref FuelTypeID);

            return isFound ? new clsFuelType(FuelTypeID, FuelTypeName) : null;
        }

        public static DataTable GetAllFuelTypes()
        {
            return clsFuelTypeData.GetAllFuelTypes();
        }

    }
}
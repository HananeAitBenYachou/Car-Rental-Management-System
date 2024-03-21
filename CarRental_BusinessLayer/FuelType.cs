using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class FuelType
    {
        public int? FuelTypeID { get; private set; }
        public string FuelTypeName { get; set; }

        private FuelType(int? FuelTypeID, string FuelTypeName)
        {
            this.FuelTypeID = FuelTypeID;
            this.FuelTypeName = FuelTypeName;
        }

        public static FuelType Find(int? FuelTypeID)
        {
            string FuelTypeName = default;

            bool isFound = FuelTypeData.GetFuelTypeInfoByID(FuelTypeID, ref FuelTypeName);

            return isFound ? new FuelType(FuelTypeID, FuelTypeName) : null;
        }

        public static FuelType Find(string FuelTypeName)
        {
            int? FuelTypeID = default;

            bool isFound = FuelTypeData.GetFuelTypeInfoByName(FuelTypeName, ref FuelTypeID);

            return isFound ? new FuelType(FuelTypeID, FuelTypeName) : null;
        }

        public static DataTable GetAllFuelTypes()
        {
            return FuelTypeData.GetAllFuelTypes();
        }

    }
}
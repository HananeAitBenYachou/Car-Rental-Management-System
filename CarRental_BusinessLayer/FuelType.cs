using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class FuelType
    {
        public int? FuelTypeID { get; private set; }
        public string FuelTypeName { get; set; }

        private FuelType(int? fuelTypeID, string fuelTypeName)
        {
            FuelTypeID = fuelTypeID;
            FuelTypeName = fuelTypeName;
        }

        public static FuelType Find(int? fuelTypeID)
        {
            string fuelTypeName = default;

            bool isFound = FuelTypeData.GetFuelTypeInfoByID(fuelTypeID, ref fuelTypeName);

            return isFound ? new FuelType(fuelTypeID, fuelTypeName) : null;
        }

        public static FuelType Find(string fuelTypeName)
        {
            int? fuelTypeID = default;

            bool isFound = FuelTypeData.GetFuelTypeInfoByName(fuelTypeName, ref fuelTypeID);

            return isFound ? new FuelType(fuelTypeID, fuelTypeName) : null;
        }

        public static DataTable GetAllFuelTypes()
        {
            return FuelTypeData.GetAllFuelTypes();
        }
    }
}
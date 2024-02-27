using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsFuelType
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? FuelTypeID { get; private set; }
        public string FuelTypeName { get; set; }

        public clsFuelType()
        {
            _Mode = enMode.AddNew;
            FuelTypeID = null;
            FuelTypeName = default;
        }
        private clsFuelType(int? FuelTypeID, string FuelTypeName)
        {
            _Mode = enMode.Update;
            this.FuelTypeID = FuelTypeID;
            this.FuelTypeName = FuelTypeName;
        }

        public static clsFuelType Find(int? FuelTypeID)
        {
            string FuelTypeName = default;

            bool isFound = clsFuelTypeData.GetFuelTypeInfoByID(FuelTypeID, ref FuelTypeName);

            if (isFound)
                return new clsFuelType(FuelTypeID, FuelTypeName);
            else
                return null;
        }

        public static bool DoesFuelTypeExist(int? FuelTypeID)
        {
            return clsFuelTypeData.DoesFuelTypeExist(FuelTypeID);
        }

        private bool _AddNewFuelType()
        {
            FuelTypeID = clsFuelTypeData.AddNewFuelType(FuelTypeName);
            return FuelTypeID.HasValue;
        }

        private bool _UpdateFuelType()
        {
            return clsFuelTypeData.UpdateFuelTypeInfo(FuelTypeID, FuelTypeName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFuelType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateFuelType();

            }
            return false;
        }

        public static bool DeleteFuelType(int? FuelTypeID)
        {
            return clsFuelTypeData.DeleteFuelType(FuelTypeID);
        }

        public static DataTable GetAllFuelTypes()
        {
            return clsFuelTypeData.GetAllFuelTypes();
        }

    }
}
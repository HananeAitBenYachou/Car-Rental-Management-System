using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Vehicle
    {
        private enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _mode;
        public int? VehicleID { get; private set; }
        public int MakeID { get; set; }
        public int ModelID { get; set; }
        public int SubModelID { get; set; }
        public string VehicleName { get; set; }
        public short Year { get; set; }
        public int DriveTypeID { get; set; }
        public string Engine { get; set; }
        public int FuelTypeID { get; set; }
        public byte NumDoors { get; set; }
        public int Mileage { get; set; }
        public double RentalPricePerDay { get; set; }
        public bool IsAvailableForRent { get; set; }

        public SubModel SubModelInfo { get; }
        public DriveType DriveTypeInfo { get; }
        public FuelType FuelTypeInfo { get; }

        public Vehicle()
        {
            _mode = enMode.AddNew;

            VehicleID = null;
            MakeID = default;
            ModelID = default;
            SubModelID = default;
            VehicleName = default;
            Year = default;
            DriveTypeID = default;
            Engine = null;
            FuelTypeID = default;
            NumDoors = default;
            Mileage = default;
            RentalPricePerDay = default;
            IsAvailableForRent = default;
        }
        private Vehicle(int? vehicleID, int makeID, int modelID, int subModelID, string vehicleName, short year,
                        int driveTypeID, string engine, int fuelTypeID, byte numDoors, int mileage,
                        double rentalPricePerDay, bool isAvailableForRent)
        {
            _mode = enMode.Update;

            VehicleID = vehicleID;
            MakeID = makeID;
            ModelID = modelID;
            SubModelID = subModelID;
            VehicleName = vehicleName;
            Year = year;
            DriveTypeID = driveTypeID;
            Engine = engine;
            FuelTypeID = fuelTypeID;
            NumDoors = numDoors;
            Mileage = mileage;
            RentalPricePerDay = rentalPricePerDay;
            IsAvailableForRent = isAvailableForRent;

            SubModelInfo = SubModel.Find(subModelID);
            DriveTypeInfo = DriveType.Find(driveTypeID);
            FuelTypeInfo = FuelType.Find(fuelTypeID);
        }

        public static Vehicle Find(int? vehicleID)
        {
            int makeID = default;
            int modelID = default;
            int subModelID = default;
            string vehicleName = default;
            short year = default;
            int driveTypeID = default;
            string engine = default;
            int fuelTypeID = default;
            byte numDoors = default;
            int mileage = default;
            double rentalPricePerDay = default;
            bool isAvailableForRent = default;

            bool isFound = VehicleData.GetVehicleInfoByID(vehicleID, ref makeID, ref modelID, ref subModelID,
                                                          ref vehicleName, ref year, ref driveTypeID, ref engine,
                                                          ref fuelTypeID, ref numDoors, ref mileage,
                                                          ref rentalPricePerDay, ref isAvailableForRent);

            if (isFound)
                return new Vehicle(vehicleID, makeID, modelID, subModelID, vehicleName, year, driveTypeID, engine,
                                   fuelTypeID, numDoors, mileage, rentalPricePerDay, isAvailableForRent);
            else
                return null;
        }

        public static bool DoesVehicleExist(int? vehicleID)
        {
            return VehicleData.DoesVehicleExist(vehicleID);
        }

        private bool AddNewVehicle()
        {
            VehicleID = VehicleData.AddNewVehicle(MakeID, ModelID, SubModelID, VehicleName, Year, DriveTypeID, Engine,
                                                  FuelTypeID, NumDoors, Mileage, RentalPricePerDay, IsAvailableForRent);
            return VehicleID.HasValue;
        }

        private bool UpdateVehicle()
        {
            return VehicleData.UpdateVehicleInfo(VehicleID, MakeID, ModelID, SubModelID, VehicleName, Year, DriveTypeID,
                                                 Engine, FuelTypeID, NumDoors, Mileage, RentalPricePerDay,
                                                 IsAvailableForRent);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.AddNew:
                    if (AddNewVehicle())
                    {
                        _mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return UpdateVehicle();

            }
            return false;
        }

        public static bool DeleteVehicle(int? vehicleID)
        {
            return VehicleData.DeleteVehicle(vehicleID);
        }

        public static DataTable GetAllVehicles(int pageNumber, int rowsPerPage)
        {
            return VehicleData.GetAllVehicles(pageNumber, rowsPerPage);
        }

        public static int GetTotalVehiclesCount()
        {
            return VehicleData.GetTotalVehiclesCount();
        }

    }
}
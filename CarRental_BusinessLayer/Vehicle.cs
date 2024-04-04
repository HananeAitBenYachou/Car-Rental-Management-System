using CarRental_DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Vehicle
    {
        private enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode;

        public enum EnVehicleStatus : byte { Available = 1, Rented = 0 };
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
            _mode = EnMode.AddNew;

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
            _mode = EnMode.Update;

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
                case EnMode.AddNew:
                    if (AddNewVehicle())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateVehicle();

            }
            return false;
        }

        public static bool DeleteVehicle(int? vehicleID)
        {
            return VehicleData.DeleteVehicle(vehicleID);
        }

        public static DataTable GetVehiclesPaginated(int pageNumber, int rowsPerPage)
        {
            return VehicleData.GetVehiclesPaginated(pageNumber, rowsPerPage);
        }

        public static DataTable GetAllVehicles()
        {
            return VehicleData.GetAllVehicles();
        }

        public static DataTable GetVehicleMaintenances(int? vehicleID)
        {
            return VehicleData.GetVehicleMaintenances(vehicleID);
        }

        public static DataTable GetVehicleRentalBookings(int? vehicleID)
        {
            return VehicleData.GetVehicleRentalBookings(vehicleID);
        }

        public static int GetTotalVehiclesCount()
        {
            return VehicleData.GetTotalVehiclesCount();
        }

        public static List<(int vehicleId, string vehicleName, int rank)> GetTopMostRentedVehicles()
        {
            return VehicleData.GetTopMostRentedVehicles();
        }

        public static int GetVehiclesCountPerStatus(EnVehicleStatus vehicleStatus)
        {
            return VehicleData.GetVehiclesCountPerStatus(vehicleStatus == EnVehicleStatus.Available);
        }
    
    }
}
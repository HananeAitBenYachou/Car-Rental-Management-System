using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Vehicle
    {
        private enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _Mode;
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
            _Mode = enMode.AddNew;
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
        private Vehicle(int? VehicleID, int MakeID, int ModelID, int SubModelID, string VehicleName,
            short Year, int DriveTypeID, string Engine, int FuelTypeID, byte NumDoors,
            int Mileage, double RentalPricePerDay, bool IsAvailableForRent)
        {
            _Mode = enMode.Update;
            this.VehicleID = VehicleID;
            this.MakeID = MakeID;
            this.ModelID = ModelID;
            this.SubModelID = SubModelID;
            this.VehicleName = VehicleName;
            this.Year = Year;
            this.DriveTypeID = DriveTypeID;
            this.Engine = Engine;
            this.FuelTypeID = FuelTypeID;
            this.NumDoors = NumDoors;
            this.Mileage = Mileage;
            this.RentalPricePerDay = RentalPricePerDay;
            this.IsAvailableForRent = IsAvailableForRent;

            this.SubModelInfo = SubModel.Find(SubModelID);
            this.DriveTypeInfo = DriveType.Find(DriveTypeID);
            this.FuelTypeInfo = FuelType.Find(FuelTypeID);
        }

        public static Vehicle Find(int? VehicleID)
        {
            int MakeID = default;
            int ModelID = default;
            int SubModelID = default;
            string VehicleName = default;
            short Year = default;
            int DriveTypeID = default;
            string Engine = default;
            int FuelTypeID = default;
            byte NumDoors = default;
            int Mileage = default;
            double RentalPricePerDay = default;
            bool IsAvailableForRent = default;

            bool isFound = VehicleData.GetVehicleInfoByID(VehicleID, ref MakeID, ref ModelID, ref SubModelID,
                ref VehicleName, ref Year, ref DriveTypeID, ref Engine, ref FuelTypeID, ref NumDoors, ref Mileage,
                ref RentalPricePerDay, ref IsAvailableForRent);

            if (isFound)
                return new Vehicle(VehicleID, MakeID, ModelID, SubModelID, VehicleName, Year, DriveTypeID, Engine,
                    FuelTypeID, NumDoors, Mileage, RentalPricePerDay, IsAvailableForRent);
            else
                return null;
        }

        public static bool DoesVehicleExist(int? VehicleID)
        {
            return VehicleData.DoesVehicleExist(VehicleID);
        }

        private bool _AddNewVehicle()
        {
            VehicleID = VehicleData.AddNewVehicle(MakeID, ModelID, SubModelID, VehicleName, Year,
                DriveTypeID, Engine, FuelTypeID, NumDoors, Mileage, RentalPricePerDay, IsAvailableForRent);
            return VehicleID.HasValue;
        }

        private bool _UpdateVehicle()
        {
            return VehicleData.UpdateVehicleInfo(VehicleID, MakeID, ModelID, SubModelID, VehicleName,
                Year, DriveTypeID, Engine, FuelTypeID, NumDoors, Mileage, RentalPricePerDay, IsAvailableForRent);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicle())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateVehicle();

            }
            return false;
        }

        public static bool DeleteVehicle(int? VehicleID)
        {
            return VehicleData.DeleteVehicle(VehicleID);
        }

        public static DataTable GetAllVehicles(int PageNumber, int RowsPerPage)
        {
            return VehicleData.GetAllVehicles(PageNumber, RowsPerPage);
        }

        public static int GetTotalVehiclesCount()
        {
            return VehicleData.GetTotalVehiclesCount();
        }

    }
}
using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Maintenance
    {
        private enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? MaintenanceID { get; private set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public double Cost { get; set; }

        public Maintenance()
        {
            _Mode = enMode.AddNew;
            MaintenanceID = null;
            VehicleID = default;
            Description = default;
            MaintenanceDate = default;
            Cost = default;
        }
        private Maintenance(int? MaintenanceID, int VehicleID, string Description, DateTime MaintenanceDate, double Cost)
        {
            _Mode = enMode.Update;
            this.MaintenanceID = MaintenanceID;
            this.VehicleID = VehicleID;
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;
        }

        public static Maintenance Find(int? MaintenanceID)
        {
            int VehicleID = default;
            string Description = default;
            DateTime MaintenanceDate = default;
            double Cost = default;

            bool isFound = MaintenanceData.GetMaintenanceInfoByID(MaintenanceID, ref VehicleID, ref Description, ref MaintenanceDate, ref Cost);

            if (isFound)
                return new Maintenance(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);
            else
                return null;
        }

        public static bool DoesMaintenanceExist(int? MaintenanceID)
        {
            return MaintenanceData.DoesMaintenanceExist(MaintenanceID);
        }

        private bool _AddNewMaintenance()
        {
            MaintenanceID = MaintenanceData.AddNewMaintenance(VehicleID, Description, MaintenanceDate, Cost);
            return MaintenanceID.HasValue;
        }

        private bool _UpdateMaintenance()
        {
            return MaintenanceData.UpdateMaintenanceInfo(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMaintenance())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateMaintenance();

            }
            return false;
        }

        public static bool DeleteMaintenance(int? MaintenanceID)
        {
            return MaintenanceData.DeleteMaintenance(MaintenanceID);
        }

        public static DataTable GetAllMaintenances()
        {
            return MaintenanceData.GetAllMaintenances();
        }

    }
}
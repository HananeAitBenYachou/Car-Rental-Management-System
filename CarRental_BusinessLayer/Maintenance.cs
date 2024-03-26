using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Maintenance
    {
        private enum enMode : byte { AddNew = 0, Update = 1 };
        private enMode _mode;
        public int? MaintenanceID { get; private set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public double Cost { get; set; }

        public Maintenance()
        {
            _mode = enMode.AddNew;

            MaintenanceID = null;
            VehicleID = default;
            Description = default;
            MaintenanceDate = default;
            Cost = default;
        }
        private Maintenance(int? maintenanceID, int vehicleID, string description, DateTime maintenanceDate, double cost)
        {
            _mode = enMode.Update;

            MaintenanceID = maintenanceID;
            VehicleID = vehicleID;
            Description = description;
            MaintenanceDate = maintenanceDate;
            Cost = cost;
        }

        public static Maintenance Find(int? maintenanceID)
        {
            int vehicleID = default;
            string description = default;
            DateTime maintenanceDate = default;
            double cost = default;

            bool isFound = MaintenanceData.GetMaintenanceInfoByID(maintenanceID, ref vehicleID, ref description,
                ref maintenanceDate, ref cost);

            return isFound ? new Maintenance(maintenanceID, vehicleID, description, maintenanceDate, cost) : null;
        }

        public static bool DoesMaintenanceExist(int? maintenanceID)
        {
            return MaintenanceData.DoesMaintenanceExist(maintenanceID);
        }

        private bool AddNewMaintenance()
        {
            MaintenanceID = MaintenanceData.AddNewMaintenance(VehicleID, Description, MaintenanceDate, Cost);
            return MaintenanceID.HasValue;
        }

        private bool UpdateMaintenance()
        {
            return MaintenanceData.UpdateMaintenanceInfo(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.AddNew:
                    if (AddNewMaintenance())
                    {
                        _mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return UpdateMaintenance();

            }
            return false;
        }

        public static bool DeleteMaintenance(int? maintenanceID)
        {
            return MaintenanceData.DeleteMaintenance(maintenanceID);
        }

        public static DataTable GetAllMaintenances()
        {
            return MaintenanceData.GetAllMaintenances();
        }

    }
}
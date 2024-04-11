using CarRental_DataAccessLayer;
using System;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Maintenance
    {
        private enum EnMode : byte { AddNew = 0, Update = 1 };
        private EnMode _mode;
        public int? MaintenanceID { get; private set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public double Cost { get; set; }

        public Maintenance()
        {
            _mode = EnMode.AddNew;

            MaintenanceID = null;
            VehicleID = default;
            Description = default;
            MaintenanceDate = default;
            Cost = default;
        }
        private Maintenance(int? maintenanceID, int vehicleID, string description, DateTime maintenanceDate, double cost)
        {
            _mode = EnMode.Update;

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
                case EnMode.AddNew:
                    if (AddNewMaintenance())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return UpdateMaintenance();

            }
            return false;
        }

        public static DataTable GetAllMaintenances()
        {
            return MaintenanceData.GetAllMaintenances();
        }

        public static DataTable GetAllMaintenancesByDateRange(DateTime startDate, DateTime endDate)
        {
            return MaintenanceData.GetAllMaintenancesByDateRange(startDate,endDate);
        }

    }
}
using CarRental_BusinessLayer;
using CarRentalManagementSystem.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace CarRentalManagementSystem.Vehicles.UserControls
{
    public partial class ucVehicleCard : UserControl
    {
        public int? VehicleID { get; private set; } = null;
        public clsVehicle Vehicle { get; private set; } = null;

        public ucVehicleCard()
        {
            InitializeComponent();
        }

        public bool LoadVehicleData(int? vehicleID)
        {
            Vehicle = clsVehicle.Find(vehicleID);

            if (Vehicle == null)
            {
                MessageBox.Show($"No vehicle with VehicleID = {vehicleID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            VehicleID = Vehicle.VehicleID;

            txtVehicleID.Text = VehicleID.ToString();
            txtVehicleName.Text = Vehicle.VehicleName;
            txtYear.Text = Vehicle.Year.ToString();
            txtEngine.Text = Vehicle.Engine ?? string.Empty;
            txtMileage.Text = Vehicle.Mileage.ToString();
            txtRentalPricePerDay.Text = Vehicle.RentalPricePerDay.ToString();
            txtMake.Text = Vehicle.SubModelInfo.ModelInfo.MakeInfo.Make;
            txtModel.Text = Vehicle.SubModelInfo.ModelInfo.ModelName;
            txtSubModel.Text = Vehicle.SubModelInfo.SubModelName;
            txtFuelType.Text = Vehicle.FuelTypeInfo.FuelTypeName;
            txtDriveType.Text = Vehicle.DriveTypeInfo.DriveTypeName;
            nudNumberOfDoors.Value = Vehicle.NumDoors;
            lblVehicleStatus.Text = Vehicle.IsAvailableForRent ? "Available" : "Rented";
            
            return true;
        }
    }
}

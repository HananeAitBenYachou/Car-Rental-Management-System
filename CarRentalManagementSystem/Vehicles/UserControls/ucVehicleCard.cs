using CarRental_BusinessLayer;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Vehicles.UserControls
{
    public partial class UcVehicleCard : UserControl
    {
        public int? VehicleID { get; private set; } = null;
        public Vehicle Vehicle { get; private set; } = null;

        public UcVehicleCard()
        {
            InitializeComponent();
        }

        public bool LoadVehicleData(int? vehicleID)
        {
            Vehicle = Vehicle.Find(vehicleID);

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
            txtMake.Text = Vehicle.SubModelInfo.ModelInfo.MakeInfo.Name;
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

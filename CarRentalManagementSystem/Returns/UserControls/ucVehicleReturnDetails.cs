using CarRental_BusinessLayer;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Returns.UserControls
{
    public partial class UcVehicleReturnDetails : UserControl
    {
        public int? ReturnID { get; private set; } = null;
        public VehicleReturn VehicleReturn { get; private set; } = null;

        public UcVehicleReturnDetails()
        {
            InitializeComponent();
        }

        public bool LoadVehicleReturnData(int? returnID)
        {
            VehicleReturn = VehicleReturn.Find(returnID);

            if (VehicleReturn == null)
            {
                MessageBox.Show($"No return with ReturnID = {returnID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ReturnID = VehicleReturn.TransactionID;

            txtReturnID.Text = ReturnID.ToString();
            txtTransactionID.Text = VehicleReturn.TransactionID.ToString();
            txtActualTotalDueAmount.Text = VehicleReturn.ActualTotalDueAmount.ToString();
            txtAdditionalCharges.Text = VehicleReturn.AdditionalCharges.ToString();
            txtMileage.Text = VehicleReturn.Mileage.ToString();
            txtConsumedMileage.Text = VehicleReturn.ConsumedMileage.ToString();
            txtFinalCheckNotes.Text = VehicleReturn.FinalCheckNotes ?? string.Empty;
            dtpActualReturnDate.Value = VehicleReturn.ActualReturnDate;
            nudActualRentalDays.Value = VehicleReturn.ActualRentalDays;

            return true;
        }

    }
}

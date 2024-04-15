using CarRental_BusinessLayer;
using CarRentalManagementSystem.Customers.UserControls;
using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Returns
{
    public partial class FrmShowVehicleReturnDetails : Form
    {
        private readonly int? _returnID = null;
        private VehicleReturn _vehicleReturn = null;

        public FrmShowVehicleReturnDetails(int? returnID)
        {
            InitializeComponent();
            _returnID = returnID;
        }

        private void LoadVehicleReturnData()
        {
            _vehicleReturn = VehicleReturn.Find(_returnID);

            if (_vehicleReturn == null)
            {
                MessageBox.Show($"No return with returnID = {_returnID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;
            }

         
            ucCustomerCard1.LoadCustomerData(_vehicleReturn.RentalBookingInfo.CustomerID);
            ucVehicleCard1.LoadVehicleData(_vehicleReturn.RentalBookingInfo.VehicleID);
            ucVehicleReturnDetails1.LoadVehicleReturnData(_vehicleReturn.ReturnID);
        }

        private void FrmShowVehicleReturnDetails_Load(object sender, EventArgs e)
        {
            LoadVehicleReturnData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

using CarRental_BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Returns
{
    public partial class frmShowVehicleReturnDetails : Form
    {
        private int? _ReturnID = null;
        private VehicleReturn _VehicleReturn = null;

        public frmShowVehicleReturnDetails(int? returnID)
        {
            InitializeComponent();
            _ReturnID = returnID;
        }

        private void _LoadVehicleReturnData()
        {
            _VehicleReturn = VehicleReturn.Find(_ReturnID);

            if (_VehicleReturn == null)
            {
                MessageBox.Show($"No return with returnID = {_ReturnID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;
            }

            ucCustomerCard1.LoadCustomerData(_VehicleReturn.TransactionInfo.RentalBookingInfo.CustomerID);
            ucVehicleCard1.LoadVehicleData(_VehicleReturn.TransactionInfo.RentalBookingInfo.VehicleID);
            ucVehicleReturnDetails1.LoadVehicleReturnData(_VehicleReturn.ReturnID);
        }

        private void frmShowVehicleReturnDetails_Load(object sender, EventArgs e)
        {
            _LoadVehicleReturnData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

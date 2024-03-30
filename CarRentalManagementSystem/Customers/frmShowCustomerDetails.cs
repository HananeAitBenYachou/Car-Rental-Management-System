using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customers
{
    public partial class FrmShowCustomerDetails : Form
    {
        public FrmShowCustomerDetails(int? customerID)
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                if (!ucCustomerCard1.LoadCustomerData(customerID))
                    btnClose.PerformClick();
            };
        }

        public FrmShowCustomerDetails(string driverLicenseNumber)
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                if (!ucCustomerCard1.LoadCustomerData(driverLicenseNumber))
                    btnClose.PerformClick();
            };
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

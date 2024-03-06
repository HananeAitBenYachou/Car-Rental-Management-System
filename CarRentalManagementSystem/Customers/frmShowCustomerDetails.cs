using CarRentalManagementSystem.Users.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customers
{
    public partial class frmShowCustomerDetails : Form
    {
        public frmShowCustomerDetails(int? customerID)
        {
            InitializeComponent();
            Load += (sender, e) => ucCustomerCard1.LoadCustomerData(customerID);
        }

        public frmShowCustomerDetails(string driverLicenseNumber)
        {
            InitializeComponent();
            Load += (sender, e) => ucCustomerCard1.LoadCustomerData(driverLicenseNumber);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

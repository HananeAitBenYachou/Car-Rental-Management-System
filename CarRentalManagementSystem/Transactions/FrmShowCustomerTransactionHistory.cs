using CarRental_BusinessLayer;
using CarRentalManagementSystem.Customers.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Transactions
{
    public partial class FrmShowCustomerTransactionHistory : Form
    {
        private int? _transactionID = null;

        public FrmShowCustomerTransactionHistory(int? customerID)
        {
            InitializeComponent();
            _transactionID = customerID;
        }

        private void FrmShowCustomerTransactionHistory_Load(object sender, EventArgs e)
        {
            if (!ucTransactionDetails1.LoadTransactionData(_transactionID))
                return;

            dgvTransactionsList.DataSource = Customer.GetCustomerRentalBookings(_transactionID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}

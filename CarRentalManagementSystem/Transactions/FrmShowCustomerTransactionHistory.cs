using CarRental_BusinessLayer;
using CarRentalManagementSystem.Bookings;
using CarRentalManagementSystem.Customers;
using CarRentalManagementSystem.Customers.UserControls;
using CarRentalManagementSystem.Returns;
using CarRentalManagementSystem.Vehicles;
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
        private readonly int? _customerID = null;

        public FrmShowCustomerTransactionHistory(int? customerID)
        {
            InitializeComponent();
            _customerID = customerID;
        }

        private void FrmShowCustomerTransactionHistory_Load(object sender, EventArgs e)
        {
            if (!ucCustomerCard1.LoadCustomerData(_customerID))
                return;

            dgvTransactionsList.DataSource = Customer.GetCustomerRentalTransactions(_customerID);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowTransactionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTransactionDetails form = new FrmShowTransactionDetails((int)dgvTransactionsList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvTransactionsList_SelectionChanged(object sender, EventArgs e)
        {
            cbRentalTransactions.Enabled = dgvTransactionsList.SelectedRows.Count > 0;
        }

        private void DgvTransactionsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showTransactionInformationToolStripMenuItem.PerformClick();
        }

        private void ShowVehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalTransaction transaction = RentalTransaction.Find((int)dgvTransactionsList.CurrentRow.Cells[0].Value
                , RentalTransaction.EnFindTransactionBy.TransactionID);

            FrmShowVehicleDetails form = new FrmShowVehicleDetails(transaction.RentalBookingInfo.VehicleID);
            form.ShowDialog();
        }

        private void ShowBookingInforamtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowBookingDetails form = new FrmShowBookingDetails((int)dgvTransactionsList.CurrentRow.Cells["Vehicle ID"].Value);
            form.ShowDialog();
        }

        private void ShowReturnInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowVehicleReturnDetails form = new FrmShowVehicleReturnDetails((int)dgvTransactionsList.CurrentRow.Cells["Return ID"].Value);
            form.ShowDialog();
        }

    }

}

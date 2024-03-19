using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Transactions.UserControls
{
    public partial class ucTransactionDetails : UserControl
    {
        public int? TransactionID { get; private set; } = null;
        public clsRentalTransaction Transaction { get; private set; } = null;

        public ucTransactionDetails()
        {
            InitializeComponent();
        }

        public bool LoadTransactionData(int? transactionID)
        {
            Transaction = clsRentalTransaction.Find<int?>(transactionID, clsRentalTransaction.enFindTransactionBy.TransactionID);

            if (Transaction == null)
            {
                MessageBox.Show($"No transaction with TransactionID = {transactionID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            TransactionID = Transaction.TransactionID;

            txtTransactionID.Text = TransactionID.ToString();
            txtBookingID.Text = Transaction.BookingID.ToString();
            txtReturnID.Text = Transaction.ReturnID.HasValue ? Transaction.ReturnID.ToString() : "N/A";
            txtInitialTotalDueAmount.Text = Transaction.PaidInitialTotalDueAmount.ToString();
            txtActualTotalDueAmount.Text = Transaction.ActualTotalDueAmount.HasValue ? Transaction.ActualTotalDueAmount.ToString() : "N/A" ;
            txtTotalRemaining.Text = Transaction.TotalRemaining.HasValue ? Transaction.TotalRemaining.ToString() : "N/A";
            txtTotalRefundedAmount.Text = Transaction.TotalRefundedAmount.HasValue ? Transaction.TotalRemaining.ToString() : "N/A";
            dtpTransactionDate.Value = Transaction.TransactionDate;
            dtpTransactionUpdatedDate.Value = Transaction.UpdatedTransactionDate.HasValue ? Transaction.UpdatedTransactionDate.Value : Transaction.TransactionDate;

            return true;
        }
    }
}

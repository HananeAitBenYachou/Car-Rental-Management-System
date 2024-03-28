using CarRental_BusinessLayer;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Transactions.UserControls
{
    public partial class UcTransactionDetails : UserControl
    {
        public int? TransactionID { get; private set; } = null;
        public RentalTransaction Transaction { get; private set; } = null;

        public UcTransactionDetails()
        {
            InitializeComponent();
        }

        public bool LoadTransactionData(int? transactionID)
        {
            Transaction = RentalTransaction.Find(transactionID, RentalTransaction.EnFindTransactionBy.TransactionID);

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
            txtActualTotalDueAmount.Text = Transaction.ActualTotalDueAmount.HasValue ? Transaction.ActualTotalDueAmount.ToString() : "N/A";
            txtTotalRemaining.Text = Transaction.TotalRemaining.HasValue ? Transaction.TotalRemaining.ToString() : "N/A";
            txtTotalRefundedAmount.Text = Transaction.TotalRefundedAmount.HasValue ? Transaction.TotalRemaining.ToString() : "N/A";
            dtpTransactionDate.Value = Transaction.TransactionDate;
            dtpTransactionUpdatedDate.Value = Transaction.UpdatedTransactionDate.HasValue ? Transaction.UpdatedTransactionDate.Value : Transaction.TransactionDate;

            return true;
        }

    }
}

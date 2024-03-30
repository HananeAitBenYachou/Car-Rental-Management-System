using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Transactions
{
    public partial class FrmShowTransactionDetails : Form
    {
        private readonly int? _transactionID = null;

        public FrmShowTransactionDetails(int? transactionID)
        {
            InitializeComponent();
            _transactionID = transactionID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowTransactionDetails_Load(object sender, EventArgs e)
        {
            if (!ucTransactionDetails1.LoadTransactionData(_transactionID))
                btnClose.PerformClick();
        }

    }
}

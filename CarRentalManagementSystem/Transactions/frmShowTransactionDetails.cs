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
    public partial class frmShowTransactionDetails : Form
    {
        private int? _TransactionID = null;

        public frmShowTransactionDetails(int? transactionID)
        {
            InitializeComponent();
            _TransactionID = transactionID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowTransactionDetails_Load(object sender, EventArgs e)
        {
            if (!ucTransactionDetails1.LoadTransactionData(_TransactionID))
                btnClose.PerformClick();
        }

    }
}

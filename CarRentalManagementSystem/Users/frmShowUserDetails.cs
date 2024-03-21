using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Users
{
    public partial class frmShowUserDetails : Form
    {
        public frmShowUserDetails(int? userID)
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                if (!ucUserCard1.LoadUserData(userID))
                    btnClose.PerformClick();
            };
        }

        public frmShowUserDetails(string userName)
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                if (!ucUserCard1.LoadUserData(userName))
                    btnClose.PerformClick();
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

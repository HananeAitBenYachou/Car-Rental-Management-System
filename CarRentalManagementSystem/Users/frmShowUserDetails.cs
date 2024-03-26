using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Users
{
    public partial class FrmShowUserDetails : Form
    {
        public FrmShowUserDetails(int? userID)
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                if (!ucUserCard1.LoadUserData(userID))
                    btnClose.PerformClick();
            };
        }

        public FrmShowUserDetails(string userName)
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                if (!ucUserCard1.LoadUserData(userName))
                    btnClose.PerformClick();
            };
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

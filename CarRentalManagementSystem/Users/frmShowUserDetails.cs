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

namespace CarRentalManagementSystem.Users
{
    public partial class frmShowUserDetails : Form
    {
        public frmShowUserDetails(int? userID)
        {
            InitializeComponent();

            Load += (sender, e) =>
            {
                if(!ucUserCard1.LoadUserData(userID))
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

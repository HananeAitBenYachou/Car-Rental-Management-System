using CarRental_BusinessLayer;
using CarRentalManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static CarRental_BusinessLayer.clsUser;

namespace CarRentalManagementSystem.Users.UserControls
{
    public partial class ucUserCard : UserControl
    {
        public int? PersonID => ucPersonCard1.PersonID;
        public clsPerson Person => ucPersonCard1.Person;

        public int? UserID { get; private set; } = null;
        public clsUser User { get; private set; } = null;

        public ucUserCard()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtUserID.Text = "N/A";
            tsIsActive.Checked = true;
            txtUserName.ResetText();
            ucPersonCard1.Reset();

            UserID = null;
            User = null;
        }

        private void _LoadUserData()
        {
            UserID = User.UserID;

            txtUserID.Text = UserID.ToString();
            txtUserName.Text = User.UserName;
            tsIsActive.Checked = User.IsActive;

            ucPersonCard1.LoadPersonData(User.PersonID);
        }

        public bool LoadUserData(int? userID)
        {
            User = clsUser.Find<int?>(userID,enFindUserBy.UserID);

            if (User == null)
            {
                Reset();
                MessageBox.Show($"No user with ID = {userID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _LoadUserData();
            return true;
        }

        public bool LoadUserData(string userName)
        {
            User = clsUser.Find<string>(userName, enFindUserBy.UserName);

            if (User == null)
            {
                Reset();
                MessageBox.Show($"No user with username = {userName} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _LoadUserData();
            return true;
        }

    }
}

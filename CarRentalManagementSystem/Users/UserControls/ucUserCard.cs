using CarRental_BusinessLayer;
using System.Windows.Forms;
using static CarRental_BusinessLayer.User;

namespace CarRentalManagementSystem.Users.UserControls
{
    public partial class ucUserCard : UserControl
    {
        public int? PersonID => ucPersonCard1.PersonID;
        public Person Person => ucPersonCard1.Person;

        public int? UserID { get; private set; } = null;
        public User User { get; private set; } = null;

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

        private void LoadUserData()
        {
            UserID = User.UserID;

            txtUserID.Text = UserID.ToString();
            txtUserName.Text = User.UserName;
            tsIsActive.Checked = User.IsActive;

            ucPersonCard1.LoadPersonData(User.PersonID);
        }

        public bool LoadUserData(int? userID)
        {
            User = User.Find<int?>(userID, EnFindUserBy.UserID);

            if (User == null)
            {
                Reset();
                MessageBox.Show($"No user with ID = {userID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LoadUserData();
            return true;
        }

        public bool LoadUserData(string userName)
        {
            User = User.Find<string>(userName, EnFindUserBy.UserName);

            if (User == null)
            {
                Reset();
                MessageBox.Show($"No user with username = {userName} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            LoadUserData();
            return true;
        }

    }
}

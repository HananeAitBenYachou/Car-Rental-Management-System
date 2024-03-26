using CarRental_BusinessLayer;

namespace CarRentalManagementSystem.Global
{
    public static class Global
    {
        private static User _currentUser = null;

        public static User CurrentUser
        {
            get
            {
                return _currentUser;
            }

            set
            {
                _currentUser = value;
            }
        }

    }
}

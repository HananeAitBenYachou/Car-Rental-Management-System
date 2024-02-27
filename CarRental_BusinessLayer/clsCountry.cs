using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsCountry
    {
        public int? CountryID { get; private set; }
        public string CountryName { get; set; }

        private clsCountry(int? CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountry Find(int? CountryID)
        {
            string CountryName = default;

            bool isFound = clsCountryData.GetCountryInfoByID(CountryID, ref CountryName);

            return isFound ? new clsCountry(CountryID, CountryName) : null;
        }

        public static bool DoesCountryExist(int? CountryID)
        {
            return clsCountryData.DoesCountryExist(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }
}
using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Country
    {
        public int? CountryID { get; private set; }
        public string Name { get; set; }

        private Country(int? CountryID, string Name)
        {
            this.CountryID = CountryID;
            this.Name = Name;
        }

        public static Country Find(int? CountryID)
        {
            string CountryName = default;

            bool isFound = CountryData.GetCountryInfoByID(CountryID, ref CountryName);

            return isFound ? new Country(CountryID, CountryName) : null;
        }

        public static Country Find(string Name)
        {
            int? CountryID = default;

            bool isFound = CountryData.GetCountryInfoByName(Name, ref CountryID);

            return isFound ? new Country(CountryID, Name) : null;
        }

        public static DataTable GetAllCountries()
        {
            return CountryData.GetAllCountries();
        }

    }
}
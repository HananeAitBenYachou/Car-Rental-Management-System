using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Country
    {
        public int? CountryID { get; private set; }
        public string Name { get; set; }

        private Country(int? countryID, string name)
        {
            CountryID = countryID;
            Name = name;
        }

        public static Country Find(int? countryID)
        {
            string CountryName = default;

            bool isFound = CountryData.GetCountryInfoByID(countryID, ref CountryName);

            return isFound ? new Country(countryID, CountryName) : null;
        }

        public static Country Find(string name)
        {
            int? CountryID = default;

            bool isFound = CountryData.GetCountryInfoByName(name, ref CountryID);

            return isFound ? new Country(CountryID, name) : null;
        }

        public static DataTable GetAllCountries()
        {
            return CountryData.GetAllCountries();
        }

    }
}
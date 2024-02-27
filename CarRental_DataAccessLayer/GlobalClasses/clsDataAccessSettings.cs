using System.Configuration;


namespace CarRental_DataAccessLayer.GlobalClasses
{
    internal static class clsDataAccessSettings
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}

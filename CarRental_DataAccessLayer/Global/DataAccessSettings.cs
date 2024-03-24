using System.Configuration;


namespace CarRental_DataAccessLayer.GlobalClasses
{
    internal static class DataAccessSettings
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}

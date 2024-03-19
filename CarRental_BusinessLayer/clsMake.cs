using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsMake
    {       
        public int? MakeID { get; private set; }
        public string Make { get; set; }

        private clsMake(int? MakeID, string Make)
        {
            this.MakeID = MakeID;
            this.Make = Make;
        }

        public static clsMake Find(int? MakeID)
        {
            string Make = default;

            bool isFound = clsMakeData.GetMakeInfoByID(MakeID, ref Make);

            return isFound ? new clsMake(MakeID, Make) : null;
        }

        public static clsMake Find(string Make)
        {
            int? MakeID = default;

            bool isFound = clsMakeData.GetMakeInfoByName(Make , ref MakeID);

            return isFound ? new clsMake(MakeID, Make) : null;
        }

        public static DataTable GetAllMakes()
        {
            return clsMakeData.GetAllMakes();
        }
    }
}
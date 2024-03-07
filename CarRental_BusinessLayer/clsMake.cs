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

            if (isFound)
                return new clsMake(MakeID, Make);
            else
                return null;
        }

        public static DataTable GetAllMakes()
        {
            return clsMakeData.GetAllMakes();
        }

    }
}
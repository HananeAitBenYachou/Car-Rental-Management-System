using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Make
    {
        public int? MakeID { get; private set; }
        public string Name { get; set; }

        private Make(int? MakeID, string Name)
        {
            this.MakeID = MakeID;
            this.Name = Name;
        }

        public static Make Find(int? MakeID)
        {
            string Name = default;

            bool isFound = MakeData.GetMakeInfoByID(MakeID, ref Name);

            return isFound ? new Make(MakeID, Name) : null;
        }

        public static Make Find(string Name)
        {
            int? MakeID = default;

            bool isFound = MakeData.GetMakeInfoByName(Name, ref MakeID);

            return isFound ? new Make(MakeID, Name) : null;
        }

        public static DataTable GetAllMakes()
        {
            return MakeData.GetAllMakes();
        }
    }
}
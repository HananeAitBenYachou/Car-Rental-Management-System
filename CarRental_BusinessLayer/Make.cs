using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Make
    {
        public int? MakeID { get; private set; }
        public string Name { get; set; }

        private Make(int? makeID, string name)
        {
            MakeID = makeID;
            Name = name;
        }

        public static Make Find(int? makeID)
        {
            string name = default;

            bool isFound = MakeData.GetMakeInfoByID(makeID, ref name);

            return isFound ? new Make(makeID, name) : null;
        }

        public static Make Find(string name)
        {
            int? makeID = default;

            bool isFound = MakeData.GetMakeInfoByName(name, ref makeID);

            return isFound ? new Make(makeID, name) : null;
        }

        public static DataTable GetAllMakes()
        {
            return MakeData.GetAllMakes();
        }
    }
}
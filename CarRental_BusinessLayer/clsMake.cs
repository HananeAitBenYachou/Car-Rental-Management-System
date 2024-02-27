using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsMake
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? MakeID { get; private set; }
        public string Make { get; set; }

        public clsMake()
        {
            _Mode = enMode.AddNew;
            MakeID = null;
            Make = default;
        }
        private clsMake(int? MakeID, string Make)
        {
            _Mode = enMode.Update;
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

        public static bool DoesMakeExist(int? MakeID)
        {
            return clsMakeData.DoesMakeExist(MakeID);
        }

        private bool _AddNewMake()
        {
            MakeID = clsMakeData.AddNewMake(Make);
            return MakeID.HasValue;
        }

        private bool _UpdateMake()
        {
            return clsMakeData.UpdateMakeInfo(MakeID, Make);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMake())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateMake();

            }
            return false;
        }

        public static bool DeleteMake(int? MakeID)
        {
            return clsMakeData.DeleteMake(MakeID);
        }

        public static DataTable GetAllMakes()
        {
            return clsMakeData.GetAllMakes();
        }

    }
}
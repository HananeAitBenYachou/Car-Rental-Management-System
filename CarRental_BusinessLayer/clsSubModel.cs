using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsSubModel
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? SubModelID { get; private set; }
        public int ModelID { get; set; }
        public string SubModelName { get; set; }

        public clsSubModel()
        {
            _Mode = enMode.AddNew;
            SubModelID = null;
            ModelID = default;
            SubModelName = default;
        }
        private clsSubModel(int? SubModelID, int ModelID, string SubModelName)
        {
            _Mode = enMode.Update;
            this.SubModelID = SubModelID;
            this.ModelID = ModelID;
            this.SubModelName = SubModelName;
        }

        public static clsSubModel Find(int? SubModelID)
        {
            int ModelID = default;
            string SubModelName = default;

            bool isFound = clsSubModelData.GetSubModelInfoByID(SubModelID, ref ModelID, ref SubModelName);

            if (isFound)
                return new clsSubModel(SubModelID, ModelID, SubModelName);
            else
                return null;
        }

        public static bool DoesSubModelExist(int? SubModelID)
        {
            return clsSubModelData.DoesSubModelExist(SubModelID);
        }

        private bool _AddNewSubModel()
        {
            SubModelID = clsSubModelData.AddNewSubModel(ModelID, SubModelName);
            return SubModelID.HasValue;
        }

        private bool _UpdateSubModel()
        {
            return clsSubModelData.UpdateSubModelInfo(SubModelID, ModelID, SubModelName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubModel())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateSubModel();

            }
            return false;
        }

        public static bool DeleteSubModel(int? SubModelID)
        {
            return clsSubModelData.DeleteSubModel(SubModelID);
        }

        public static DataTable GetAllSubModels()
        {
            return clsSubModelData.GetAllSubModels();
        }

    }
}
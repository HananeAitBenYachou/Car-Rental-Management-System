using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsModel
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? ModelID { get; private set; }
        public int MakeID { get; set; }
        public string ModelName { get; set; }

        public clsModel()
        {
            _Mode = enMode.AddNew;
            ModelID = null;
            MakeID = default;
            ModelName = default;
        }
        private clsModel(int? ModelID, int MakeID, string ModelName)
        {
            _Mode = enMode.Update;
            this.ModelID = ModelID;
            this.MakeID = MakeID;
            this.ModelName = ModelName;
        }

        public static clsModel Find(int? ModelID)
        {
            int MakeID = default;
            string ModelName = default;

            bool isFound = clsModelData.GetModelInfoByID(ModelID, ref MakeID, ref ModelName);

            if (isFound)
                return new clsModel(ModelID, MakeID, ModelName);
            else
                return null;
        }

        public static bool DoesModelExist(int? ModelID)
        {
            return clsModelData.DoesModelExist(ModelID);
        }

        private bool _AddNewModel()
        {
            ModelID = clsModelData.AddNewModel(MakeID, ModelName);
            return ModelID.HasValue;
        }

        private bool _UpdateModel()
        {
            return clsModelData.UpdateModelInfo(ModelID, MakeID, ModelName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewModel())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateModel();

            }
            return false;
        }

        public static bool DeleteModel(int? ModelID)
        {
            return clsModelData.DeleteModel(ModelID);
        }

        public static DataTable GetAllModels()
        {
            return clsModelData.GetAllModels();
        }

    }
}
using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsModel
    {
        public int? ModelID { get; private set; }
        public int MakeID { get; set; }
        public string ModelName { get; set; }

        public clsMake MakeInfo { get; }

        private clsModel(int? ModelID, int MakeID, string ModelName)
        {
            this.ModelID = ModelID;
            this.MakeID = MakeID;
            this.ModelName = ModelName;

            MakeInfo = clsMake.Find(MakeID);
        }

        public static clsModel Find(int? ModelID)
        {
            int MakeID = default;
            string ModelName = default;

            bool isFound = clsModelData.GetModelInfoByID(ModelID, ref MakeID, ref ModelName);

            return isFound ? new clsModel(ModelID, MakeID, ModelName) : null;
        }

        public static clsModel Find(string ModelName)
        {
            int MakeID = default;
            int? ModelID = default;

            bool isFound = clsModelData.GetModelInfoByName(ModelName , ref ModelID, ref MakeID);

            return isFound ? new clsModel(ModelID, MakeID, ModelName) : null;
        }

        public static DataTable GetAllModels()
        {
            return clsModelData.GetAllModels();
        }

        public static DataTable GetAllModelsPerMake(int MakeID)
        {
            return clsModelData.GetAllModelsPerMake(MakeID);
        }

    }
}
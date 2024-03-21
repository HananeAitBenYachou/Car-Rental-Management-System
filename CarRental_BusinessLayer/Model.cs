using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class Model
    {
        public int? ModelID { get; private set; }
        public int MakeID { get; set; }
        public string ModelName { get; set; }

        public Make MakeInfo { get; }

        private Model(int? ModelID, int MakeID, string ModelName)
        {
            this.ModelID = ModelID;
            this.MakeID = MakeID;
            this.ModelName = ModelName;

            MakeInfo = Make.Find(MakeID);
        }

        public static Model Find(int? ModelID)
        {
            int MakeID = default;
            string ModelName = default;

            bool isFound = ModelData.GetModelInfoByID(ModelID, ref MakeID, ref ModelName);

            return isFound ? new Model(ModelID, MakeID, ModelName) : null;
        }

        public static Model Find(string ModelName)
        {
            int MakeID = default;
            int? ModelID = default;

            bool isFound = ModelData.GetModelInfoByName(ModelName, ref ModelID, ref MakeID);

            return isFound ? new Model(ModelID, MakeID, ModelName) : null;
        }

        public static DataTable GetAllModels()
        {
            return ModelData.GetAllModels();
        }

        public static DataTable GetAllModelsPerMake(int MakeID)
        {
            return ModelData.GetAllModelsPerMake(MakeID);
        }

    }
}
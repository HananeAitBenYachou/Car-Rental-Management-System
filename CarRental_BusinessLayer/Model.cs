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

        private Model(int? modelID, int makeID, string modelName)
        {
            ModelID = modelID;
            MakeID = makeID;
            ModelName = modelName;

            MakeInfo = Make.Find(makeID);
        }

        public static Model Find(int? modelID)
        {
            int makeID = default;
            string modelName = default;

            bool isFound = ModelData.GetModelInfoByID(modelID, ref makeID, ref modelName);

            return isFound ? new Model(modelID, makeID, modelName) : null;
        }

        public static Model Find(string modelName)
        {
            int makeID = default;
            int? modelID = default;

            bool isFound = ModelData.GetModelInfoByName(modelName, ref modelID, ref makeID);

            return isFound ? new Model(modelID, makeID, modelName) : null;
        }

        public static DataTable GetAllModels()
        {
            return ModelData.GetAllModels();
        }

        public static DataTable GetAllModelsPerMake(int makeID)
        {
            return ModelData.GetAllModelsPerMake(makeID);
        }

    }
}
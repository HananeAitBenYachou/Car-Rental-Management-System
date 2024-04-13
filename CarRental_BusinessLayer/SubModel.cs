using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class SubModel
    {
        public int? SubModelID { get; private set; }
        public int ModelID { get; set; }
        public string SubModelName { get; set; }
        public Model ModelInfo { get; }

        private SubModel(int? subModelID, int modelID, string subModelName)
        {
            SubModelID = subModelID;
            ModelID = modelID;
            SubModelName = subModelName;

            ModelInfo = Model.Find(modelID);
        }

        public static SubModel Find(int? subModelID)
        {
            int modelID = default;
            string subModelName = default;

            bool isFound = SubModelData.GetSubModelInfoByID(subModelID, ref modelID, ref subModelName);

            return isFound ? new SubModel(subModelID, modelID, subModelName) : null;
        }

        public static SubModel Find(string subModelName)
        {
            int modelID = default;
            int? subModelID = default;

            bool isFound = SubModelData.GetSubModelInfoByName(subModelName, ref subModelID, ref modelID);

            return isFound ? new SubModel(subModelID, modelID, subModelName) : null;
        }

        public static DataTable GetAllSubModels()
        {
            return SubModelData.GetAllSubModels();
        }

        public static DataTable GetAllSubModelsPerModel(int modelID)
        {
            return SubModelData.GetAllSubModelsPerModel(modelID);
        }

    }
}
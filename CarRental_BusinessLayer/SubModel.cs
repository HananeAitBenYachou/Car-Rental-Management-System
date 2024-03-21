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
        private SubModel(int? SubModelID, int ModelID, string SubModelName)
        {
            this.SubModelID = SubModelID;
            this.ModelID = ModelID;
            this.SubModelName = SubModelName;

            this.ModelInfo = Model.Find(ModelID);
        }

        public static SubModel Find(int? SubModelID)
        {
            int ModelID = default;
            string SubModelName = default;

            bool isFound = SubModelData.GetSubModelInfoByID(SubModelID, ref ModelID, ref SubModelName);

            return isFound ? new SubModel(SubModelID, ModelID, SubModelName) : null;
        }

        public static SubModel Find(string SubModelName)
        {
            int ModelID = default;
            int? SubModelID = default;

            bool isFound = SubModelData.GetSubModelInfoByName(SubModelName, ref SubModelID, ref ModelID);

            return isFound ? new SubModel(SubModelID, ModelID, SubModelName) : null;
        }

        public static DataTable GetAllSubModels()
        {
            return SubModelData.GetAllSubModels();
        }

        public static DataTable GetAllSubModelsPerModel(int ModelID)
        {
            return SubModelData.GetAllSubModelsPerModel(ModelID);
        }

    }
}
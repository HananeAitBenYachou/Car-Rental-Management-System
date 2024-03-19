using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsSubModel
    {
        public int? SubModelID { get; private set; }
        public int ModelID { get; set; }
        public string SubModelName { get; set; }
   
        public clsModel ModelInfo { get; }
        private clsSubModel(int? SubModelID, int ModelID, string SubModelName)
        {
            this.SubModelID = SubModelID;
            this.ModelID = ModelID;
            this.SubModelName = SubModelName;

            this.ModelInfo = clsModel.Find(ModelID);
        }

        public static clsSubModel Find(int? SubModelID)
        {
            int ModelID = default;
            string SubModelName = default;

            bool isFound = clsSubModelData.GetSubModelInfoByID(SubModelID, ref ModelID, ref SubModelName);

            return isFound ? new clsSubModel(SubModelID, ModelID, SubModelName) : null;
        }

        public static clsSubModel Find(string SubModelName)
        {
            int ModelID = default;
            int? SubModelID = default;

            bool isFound = clsSubModelData.GetSubModelInfoByName(SubModelName , ref SubModelID, ref ModelID);

            return isFound ? new clsSubModel(SubModelID, ModelID, SubModelName) : null;
        }

        public static DataTable GetAllSubModels()
        {
            return clsSubModelData.GetAllSubModels();
        }

        public static DataTable GetAllSubModelsPerModel(int ModelID)
        {
            return clsSubModelData.GetAllSubModelsPerModel(ModelID);
        }

    }
}
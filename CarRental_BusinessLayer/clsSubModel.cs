using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsSubModel
    {
        public int? SubModelID { get; private set; }
        public int ModelID { get; set; }
        public string SubModelName { get; set; }
   
        private clsSubModel(int? SubModelID, int ModelID, string SubModelName)
        {
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

        public static DataTable GetAllSubModels()
        {
            return clsSubModelData.GetAllSubModels();
        }

    }
}
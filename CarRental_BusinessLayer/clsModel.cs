using CarRental_DataAccessLayer;
using System.Data;

namespace CarRental_BusinessLayer
{
    public class clsModel
    {
        public int? ModelID { get; private set; }
        public int MakeID { get; set; }
        public string ModelName { get; set; }

        private clsModel(int? ModelID, int MakeID, string ModelName)
        {
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

        public static DataTable GetAllModels()
        {
            return clsModelData.GetAllModels();
        }

    }
}
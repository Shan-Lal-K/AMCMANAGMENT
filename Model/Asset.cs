using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class Asset : TimeDetails
    {
        public string AssetName { get; set; }
        public string SerialNo { get; set; }
        public int AssetCategoryId { get; set; }
        public bool IsActive { get; set; }
        public string AssetModel { get; set; }
        public bool IsVehcile { get; set; }
    }
}

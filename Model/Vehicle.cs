using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class Vehicle : TimeDetails
    {
        public int AssetId { get; set; }
        public string VehcileName { get; set; }
        public int VehcileModel { get; set; }
        public bool IsActive { get; set; }
        public int OwnerNameId { get; set; }
        public int BodyTypeId { get; set; }
    }
}

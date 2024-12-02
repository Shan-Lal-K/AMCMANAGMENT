using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class AMC : TimeDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AssetId { get; set; }
        public int AMCTypeId { get; set; }
        public int MaintenanceTeamHeadId { get; set; }
        public int MaintenanceTeamName { get; set; }
        public int AMCTeamId { get; set; }
        public string MaintenanceTeamHeadEmail { get; set; }
    }
}

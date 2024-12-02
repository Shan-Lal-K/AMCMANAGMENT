using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class AMCTeam : TimeDetails
    {
        public string TeamName { get; set; }
        public string Description { get; set; }
        public int TeamHeadID { get; set; }
        public string HeadName { get; set; }
        public bool IsAvailable { get; set; }
    }
}

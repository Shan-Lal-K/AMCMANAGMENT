using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class MaintainenceTask : TimeDetails
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int AMCId { get; set; }
    }
}

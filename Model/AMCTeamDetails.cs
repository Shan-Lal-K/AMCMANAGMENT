using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class AMCTeamDetails : TimeDetails
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int AMCTeamId { get; set; }
        public int IsLeave { get; set; }
        public bool IsHead { get; set; }
    }
}

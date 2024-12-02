using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class Users : TimeDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsTwoFactor { get; set; }
        public string RecoveryEmail { get; set; }
    }
}

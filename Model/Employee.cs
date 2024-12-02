using AMCMANAGMENT.Model.Base;

namespace AMCMANAGMENT.Model
{
    public class Employee : TimeDetails
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
        public string PhoneNo { get; set; }
        public string PersonalEmail { get; set; }
        public string CompanyEmail { get; set; }
        public bool IsUser { get; set; }
        public string Address { get; set; }
        public int BranchId { get; set; }
        public int Status { get; set; }
        public int WorkFrom { get; set; }
    }
}

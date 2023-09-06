using System.ComponentModel.DataAnnotations;

namespace Details_Of_All_Staff_in_Softworks_Department.Net.Model.ResponseModel
{
    public class StaffResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactInfo { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
    }

    public class StaffResponseDateCreated
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactInfo { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateCreated { get; set; }
    }


}

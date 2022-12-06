using System;

namespace Leave_Management.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string TextId { get; set; }
        public string Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}

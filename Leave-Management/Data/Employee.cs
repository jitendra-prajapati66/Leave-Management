using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Leave_Management.Models
{
    public class Employee : IdentityUser
    {
        [Required]
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string TextId { get; set; }
        public string Role { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }

    }
}

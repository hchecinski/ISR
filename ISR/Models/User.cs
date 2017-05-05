using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISR.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool EmailVerified { get; set; }
        public string EmailHash { get; set; }
        public int RoleId { get; set; }
        public DateTime DateCreated { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsLocked { get; set; }
    }
}
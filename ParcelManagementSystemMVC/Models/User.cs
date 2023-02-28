﻿

using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }   
        public string State { get; set; }
        public string Country { get; set; }
        public string Branch { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsExternal { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessRole { get; set; }
    }
}

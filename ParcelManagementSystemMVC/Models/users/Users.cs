using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models.users
{
    public class Users
    {
        [Key]
        public int User_Id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        public string Email { get; set; }
        [Required]
        public string Image { get; set; }
        public bool External { get; set; }  
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }
}

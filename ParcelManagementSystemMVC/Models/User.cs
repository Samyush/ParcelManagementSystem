using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class User
    {
        [Key]
        public int  User_id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set;}
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Branch { get; set; }
        [Required]
        public string Phone_number { get; set; }
        public string Email { get; set; }
        [Required]
        public string External { get; set; }
        [Required]
        public string Role { get; set; }    
        public string Action { get; set; }
        public string Image { get; set; }


        [Required]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required"),
     MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password { get; set; }

        public ICollection<Branchdb> Branchs { get; set; }

        [ForeignKey("Role")]
        public int role_id { get; set; }    
        public rolesdb rolesdb { get; set; }    

    }
}

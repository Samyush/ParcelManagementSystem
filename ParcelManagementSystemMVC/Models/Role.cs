
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Roles { get; set; }
        public bool View { get; set; }
        public bool Manage { get; set; }
        public bool Delete { get; set; }
        public bool Export { get; set; }
        public string Action { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public userList userLists { get; set; }
       
    }
}


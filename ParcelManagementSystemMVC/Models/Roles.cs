using System.ComponentModel.DataAnnotations;
using System.Security;

namespace ParcelManagementSystemMVC.Models
{
    public class Roles
    {
        [Key]
        public string RoleName { get; set; }
        public string RoleStatus { get; set; }
        public string RoleActions { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.DBContext.Users
{
    public class UserRole
    {
        [Key]
        public int Role_Id { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
    }
}

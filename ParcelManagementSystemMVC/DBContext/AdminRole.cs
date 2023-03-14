using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.DBContext
{
    public class AdminRole
    {
        [Key]
        public int Role_Id { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
    }
}

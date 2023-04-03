using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext.User
{
    public class AdminUser
    {
        [Key]
        public int Admin_Id { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User UserId{ get; set; }
    }
}

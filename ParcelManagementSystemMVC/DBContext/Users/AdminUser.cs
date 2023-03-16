using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext.Users
{
    public class AdminUser
    {
        public int AdminId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public NewUser User_Id { get; set; }       

    }
}
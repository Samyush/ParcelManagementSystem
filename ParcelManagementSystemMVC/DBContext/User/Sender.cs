using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.DBContext.User
{
    public class Sender
    {
        [Key]
        public int Sender_Id { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User UserId { get; set; }
    }
}

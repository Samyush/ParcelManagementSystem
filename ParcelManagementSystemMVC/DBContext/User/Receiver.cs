using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.DBContext.User
{
    public class Receiver
    {
        [Key]
        public int Receiver_Id { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User UserId { get; set; }

    }
}

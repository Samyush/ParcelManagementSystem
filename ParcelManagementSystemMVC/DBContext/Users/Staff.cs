using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext.Users
{
    public class Staff
    {
        public int StaffID { get; set; }

        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public NewUser User_Id { get; set; }
    }
}

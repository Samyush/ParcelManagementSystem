using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext
{
    public class Branch
    {

        [Key]
        public int Branch_Id { get; set; }
        public string BranchName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string BranchCode { get; set; }
        public int Parcel_Id { get; set; }

        [ForeignKey("Parcel_Id")]
        public Parcel.Parcel parcel { get; set; }

        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User.User UserBranch { get; set; }


    }

}

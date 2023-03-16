using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ParcelManagementSystemMVC.Models.Parcel;
using ParcelManagementSystemMVC.Models.users;

namespace ParcelManagementSystemMVC.Models
{
    public class Branchdb
    {
        [Key]
        public int Branch_Id { get; set; }

        public string Branch_Name { get; set; }
        public string Branch_Contact { get; set; }
        public string Branch_State { get; set; }
        public string Branch_Address { get; set; }
        public string Branch_City { get; set; }
        public string Branch_Pincode { get; set; }
        public string BranchCountry { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcels Parcels { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public Users users { get; set; }

    }
}

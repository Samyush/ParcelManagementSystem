using ParcelManagementSystemMVC.Models.Parcel;
using ParcelManagementSystemMVC.Models.users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Branch
    {
        [Key] 
        public int id {get; set;}
        public int Branch_Id { get; set; }
        [ForeignKey("Branch_Id")]
        public Branchdetails branchdetail { get; set; }
        public string name { get; set; }
        public int St_Id { get; set; }
        [ForeignKey("St_Id")]
        public staff_details staff_detail { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcels parcel { get; set; }

        
    }
}

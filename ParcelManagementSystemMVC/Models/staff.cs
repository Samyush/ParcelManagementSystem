using ParcelManagementSystemMVC.Models.Parcel;
using ParcelManagementSystemMVC.Models.users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class staff
    {
        [Key]
        public int St_Id {get; set;}
        [ForeignKey("St_Id")]
        public staff_details staff_Detail { get; set; }
        public string Create_by { get; set;}
        public string Modify_by { get; set; }
        public int Percel_Id { get; set; }
                [ForeignKey("Parcel_Id")]
        public Parcels Parcel { get; set; }



    }
}

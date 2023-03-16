using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ParcelManagementSystemMVC.Models.Parcel;
using ParcelManagementSystemMVC.Models.users;

namespace ParcelManagementSystemMVC.Models
{
    public class Actiondb
    {
        [Key]
        public int Action_Id { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcels Parcelid { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public Users users { get; set; }
       
    }
}

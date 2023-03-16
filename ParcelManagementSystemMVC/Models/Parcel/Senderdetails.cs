using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.Parcel
{
    public class Senderdetails
    {
        [Key]
        public int senderid { get; set; }
        public string sendername { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcels parcel { get; set; } 
    }
}

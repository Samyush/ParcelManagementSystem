using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.Parcel
{
    public class UpdateParcel
    {
        [Key]
        public int Update_Parcel_Id { get; set; }
        public string Reason { get; set; }
        public string Document { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcels Parcel { get; set; }
    }
}

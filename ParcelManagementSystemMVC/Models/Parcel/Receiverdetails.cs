using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.Parcel
{
    public class Receiverdetails
    {
        [Key]
        public int receiverid { get; set; }
        public string receivername { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcels parcel { get; set; }


    }
}

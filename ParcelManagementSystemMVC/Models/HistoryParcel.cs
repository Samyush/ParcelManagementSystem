using ParcelManagementSystemMVC.Models.Parcel;
using ParcelManagementSystemMVC.Models.users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class HistoryParcel
    {
        [Key]
        public int History_Id { get; set; }
        public int Percel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcels Parcel { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual Users User { get; set; }


    }
}

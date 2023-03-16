using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

<<<<<<<< HEAD:ParcelManagementSystemMVC/DBContext/Parcel/ParcelCharges.cs
namespace ParcelManagementSystemMVC.DBContext.Parcel
========
namespace ParcelManagementSystemMVC.DBContext.Parcels
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/DBContext/Parcels/ParcelCharges.cs
{
    public class ParcelCharges
    {
        [Key]
        public int Charge_Id { get; set; }

        public int Rate { get; set; }
        public string Pay { get; set; }
        public int DuePaid { get; set; }
        public int VAT { get; set; }
        public int Total { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcel parcel { get; set; }


    }
}

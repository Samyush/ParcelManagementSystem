using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

<<<<<<<< HEAD:ParcelManagementSystemMVC/DBContext/Parcel/ParcelPackage.cs
namespace ParcelManagementSystemMVC.DBContext.Parcel
========
namespace ParcelManagementSystemMVC.DBContext.Parcels
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/DBContext/Parcels/ParcelPackage.cs
{
    public class ParcelPackage
    {
        [Key]
        public int Package_Id { get; set; }

        public int PacketsNumber { get; set; }
        public string Description { get; set; }
        public int AcutalWeight { get; set; }
        public int ValueOfGoods { get; set; }
        public int LorryNo { get; set; }
        public int TIN_No { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcel parcel { get; set; }



    }
}
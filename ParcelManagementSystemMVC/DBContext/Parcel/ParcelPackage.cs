using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ParcelManagementSystemMVC.DBContext.Parcels
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
        public Parcel.Parcel parcel { get; set; }



    }
}
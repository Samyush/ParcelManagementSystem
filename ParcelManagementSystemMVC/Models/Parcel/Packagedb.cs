using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.Parcel
{
    public class Packagedb
    {
        [Key]
        public int Package_Id { get; set; }
        public int No_of_Package { get; set; }

        public string Descripton { get; set; }
        public float Actual_Wait { get; set; }
        public float Values_of_goods { get; set; }
        public int Lorry_No { get; set; }
        public int Tin { get; set; }
        public int Percel_Id { get; set; }

        [ForeignKey("Parcel_Id")]
        public Parcels Parcel { get; set; }

    }
}

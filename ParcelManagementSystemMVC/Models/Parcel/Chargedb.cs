using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.Parcel
{
    public class Chargedb
    {
        [Key]
        public int Charge_Id { get; set; }
        public float Rate { get; set; }
        public float Due_Paid { get; set; }
        public float Vat { get; set; }
        public float G_Total { get; set; }
        public int Percel_Id { get; set; }

        [ForeignKey("Parcel_Id")]
        public Parcels Parcel { get; set; }


    }
}

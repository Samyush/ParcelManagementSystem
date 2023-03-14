using ParcalManagementSystemMVC.DBContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext
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

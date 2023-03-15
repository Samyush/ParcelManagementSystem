using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Charges
    {
        [Key]
        public int ChargeId { get; set; }
        public double RatePerKg { get; set; }
        public double ToPay { get; set; }
        public double DuePaid { get; set; }
        public double VatAmount { get; set; }
        public double GrossTotal { get;set; }

        //Relations
        public string WayBillNo { get; set; }
        [ForeignKey("WayBillNo")]
        public Parcels ParcelsCharges { get; set; }


    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models.DBContext
{
    public class pricetable
    {
        [Key]
        public int ChargeId { get; set; }
        public double RatePerKg { get; set; }
        public double ToPay { get; set; }
        public double DuePaid { get; set; }
        public double VatAmount { get; set; }
        public double GrossTotal { get; set; }

       
    }
}

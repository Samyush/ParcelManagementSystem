using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class Parcel
    {
        [Key]
        public int Id { get; set; } 
        public string WayBillNumber { get; set; }
        public string ShipmentStatus { get; set; }
        
        public int NoOfPackets { get; set; }
        public int LorryNo { get; set; }
        public int TinNo { get; set; }
        public string DescriptionOfGoods { get; set; }
        public int ActualWeight { get; set; }
        public int ValueofGoods { get; set; }
        public int RatePerKgs { get; set; }
        public int ToPay { get; set; }
        public int VAT { get; set; }
        public int GTotal { get; set; }

    }
}

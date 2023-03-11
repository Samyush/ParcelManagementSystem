namespace ParcelManagementSystemMVC.Models
{
    public class ParcelStatus
    {
        public string ParcelWayBillNo { get; set; }
        public string Location { get; set; }
        public string NextNode { get; set; }
        public string ShipmentStatus { get; set; }

        public DateTime Date { get; set; }  
        public DateTime Time { get; set; }
        public string VechileNumber { get; set; }
    }
}

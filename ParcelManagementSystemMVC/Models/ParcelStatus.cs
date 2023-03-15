using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
   
    public class ParcelStatus
    {
        [Key]
        public int ParcelStatusId { get; set; }
        public string CurrentLocation { get; set; }
        public string NextLocation { get; set; }
        public string ShipmentStatus { get; set; }

        public DateTime DateOfStatus { get; set; }  
        public DateTime TimeOfStatus { get; set; }
        public string VehicleNumber { get; set; }
        public string Reason { get; set; }
        public string Documents { get; set; }

        //Relations
        public int ModifiedByUserId { get; set; }
        public DateTime ModifiedTS { get; set; }
        [ForeignKey("ModifiedByUserId")]
        public  Users ModifiedUser { get; set; }
        public string ParcelWayBillNo { get; set; }
        [ForeignKey("ParcelWayBillNo")]
        public  Parcels ParcelStat { get; set; }

    }
}

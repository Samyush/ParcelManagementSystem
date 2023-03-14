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

        public DateTime Date { get; set; }  
        public DateTime Time { get; set; }
        public string VehicleNumber { get; set; }
        //Relations
        public string ParcelWayBillNo { get; set; }
        [ForeignKey("ParcelWayBillNo")]
        public Parcels Parcels { get; set; }

    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    [Keyless]
    public class HistoryofParcel
    {
        public int ParcelId { get; set; }
        [ForeignKey("ParcelId")]
        public Parcels Parcels { get; set; }

        public string Location { get; set; }
        public string NextNode { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string ShipmentStatus { get; set; }
        public string VehicleNumber { get; set; }
        public string Reason { get; set;}
        public string ModifiedBy { get; set;}
        public DateTime ModifiedTS { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Document { get; set; }




    }
}

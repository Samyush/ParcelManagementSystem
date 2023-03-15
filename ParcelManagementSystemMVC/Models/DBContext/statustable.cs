using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.DBContext
{
    public class statustable
    {
        [Key]
        public int ParcelStatusId { get; set; }

        public string CurrentLocation { get; set; }
        public string NextLocation { get; set; }
        public string ShipmentStatus { get; set; }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

    }  
}

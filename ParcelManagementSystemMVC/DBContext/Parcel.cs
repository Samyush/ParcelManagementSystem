//using ParcelManagementSystemMVC.DBContext;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcalManagementSystemMVC.DBContext
{

      public class Parcel
       {
            [Key]
            public int Parcel_Id { get; set; }
            public string WayBillNumber { get; set; }
            public string ShipmentStatus { get; set; }
            public string ParcelLocation { get; set; }
            public DateTime Date { get; set; }

       }
    
}

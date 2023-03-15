//using ParcelManagementSystemMVC.DBContext;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext.Parcel
{

    public class Parcel
    {
        [Key]
        public int Parcel_Id { get; set; }
        public string WayBillNumber { get; set; }
        public string ShipmentStatus { get; set; }
        public string ParcelLocation { get; set; }
        public string ArrivedatDestination { get; set; }
        public string InTransit { get; set; }
        public string FaildDelivery { get; set; }
        public DateTime Date { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User.User userParcel { get; set; }


    }

}

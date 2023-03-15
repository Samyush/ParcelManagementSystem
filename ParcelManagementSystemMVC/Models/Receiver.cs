using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Receiver
    {
        //Link with User Table
        public int? UserId { get; set; }
        [ForeignKey("ReceiverId")]

        public userList userLists { get; set; }

        //Link with Parcel table

        public int? ParcelId { get; set; }
        [ForeignKey("ParcelId")]
        public List<Parcels> Parcels { get; set; }

        //Link with Send_rec
        public List<Send_Rec> Sender_Receiver { get; set; }

    }
}

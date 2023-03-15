using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Sender
    {
        //Link with User Table
        public int? SenderId { get; set; }
        [ForeignKey("SenderId")]

        public userList userLists { get; set; }

        //Link with Parcel table

        public int? ParcelId { get; set; }
        [ForeignKey("ParcelId")]
        public List<Parcels> Parcels { get; set; }

        //Link with Send_rec
        public List<Send_Rec> Sender_Receiver { get; set; }

    }
}

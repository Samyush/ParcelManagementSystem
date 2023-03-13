using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Parcels
    {
        [Key]
        public int Id { get; set; }
        public string WayBillNumber { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string BranchCode { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress { get; set;}
        public string ReceiverName { get; set;}
        public string ReceiverAddress { get; set;}
        public string Status { get; set; }
        public string Location { get; set; }
        public string HistoryOfParcel { get; set; }
        public string Actions { get; set; }

        //Users
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public userList Users { get; set; }
    }
}

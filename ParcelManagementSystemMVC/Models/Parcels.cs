using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Parcels
    {
        [Key]
        public int ParcelId { get; set; }
        public string WayBillNumber { get; set; }
        public DateTime EntryDateTime { get; set; }
        public int? BranchId { get; set; }
        [ForeignKey("BranchId")]
        public Branch Branches { get; set; }
        
        public string Status { get; set; }
        

        

        

        //Link with Sender and Receiver
        public Sender Senders { get; set; }
        public Receiver Receivers { get; set; }

    }
}

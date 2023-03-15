using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }

        
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int TotalStaff { get; set; }
        public string? Actions { get; set; }

        public List<userList> userLists { get; set; }
        public List<Parcels> Parcels { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class Branch
    {
        [Key]
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        
        
    }
}

using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; } 
        public string BranchCode { get; set; }
    }
}

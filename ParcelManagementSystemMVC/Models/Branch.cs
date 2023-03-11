using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class Branch
    {
        public int Id { get; set; }
        [Display(Name = "Branch Name")]
        [Required]
        public string BranchName { get; set; }
        [Display(Name = "Street")]
        public string Street { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        [Display(Name = "Branch Code")]
        public string BranchCode { get; set; }
    }
}

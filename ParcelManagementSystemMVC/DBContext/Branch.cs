using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.DBContext
{
    public class Branch
    {

        [Key]
        public int Branch_Id { get; set; }
        public string BranchName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string BranchCode { get; set; }
    }
}

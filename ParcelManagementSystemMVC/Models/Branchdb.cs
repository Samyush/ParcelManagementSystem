using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Branchdb
    {
        [Key]
        public int Branch_ID { get; set; }

        public string Branch_Name { get; set; }
        public string Branch_Contact { get; set; }
        public string Branch_State { get; set; }
        public string Branch_Address { get; set; }
        public string Branch_City { get; set; }
        public string Branch_Pincode { get; set; }
        public string Branch_Country { get; set; }

         public ICollection<Parcels> parcels  { get; set; }
       
    }       
}

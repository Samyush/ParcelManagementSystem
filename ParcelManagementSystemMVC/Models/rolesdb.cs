using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class rolesdb
    {
        [Key]
        public int roll_id { get; set; }
        public string Name { get; set; }   
        public string status { get; set; }  
        public string Actions { get; set; }

        public ICollection <Parcels> parcels { get; set; }
        public ICollection<User>users { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.DBContext
{
    public class addnewpparcel
    {
        [Key]
        public int id { get; set; }
       
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    
    }
}

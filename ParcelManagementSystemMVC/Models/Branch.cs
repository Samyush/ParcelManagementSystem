using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class Branch
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Cann't be null")]
        public string Branch_name { get; set; } 
        public string Street { get; set; }
        public string City { get; set; }    
        public string State { get; set; }  
        public string Zip_code { get; set; }    
        public string Branch_code { get; set; }

    }
}

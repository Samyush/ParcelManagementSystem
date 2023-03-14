using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class TotalStaffdb
    {
        [Key]
        public int st_id { get; set; }
        [Required]
        public string st_Name { get; set; }
       
        public string st_Address { get; set; }      
        public string st_City { get; set;}

        public string st_Country { get; set;}   
        public string st_email { get; set;} 
        public string st_phone { get; set;}

        [ForeignKey("user_id")]
        public int User_id { get; set; }    
        public User User { get; set; }   


      
    }
}

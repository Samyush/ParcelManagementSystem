using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Jobtitledb
    {
        [Key]
        public int job_id {  get; set; }    
        public string job_description { get; set;}
        public string job_type { get; set;}
        public string job_status { get; set;}
        
        [ForeignKey ("user_id")]
        public int userId { get; set; }
        public User User { get; set; }

        

    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.users
{
    public class Jobtitledb
    {
        [Key]
        public int job_id { get; set; }
        public string job_description { get; set; }
        public string job_type { get; set; }
        public string job_status { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public Users User { get; set; }

    }
}

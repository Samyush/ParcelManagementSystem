using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.users
{
    public class jobtitles
    {
        [Key]
        public int job_id { get; set; }
        public string job_description { get; set; }
        public string job_type { get; set; }
        public string job_status { get; set; }
        public int St_Id { get; set; }
        [ForeignKey("St_Id")]
        public staff_details staff_Detail { get; set; }

    }
}

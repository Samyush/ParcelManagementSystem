using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.users
{
    public class staff_details
    {
        [Key]
        public int St_Id { get; set; }
        [Required]
        public DateTime St_Hire_Date { get; set; }
        public DateTime St_End_Date { get; set; }
        public float St_Salary { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public Users User { get; set; }
    }
}

using ParcelManagementSystemMVC.Models.users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class Rolesdb
    {
        [Key]
        public int Roll_Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public Users User { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Database
{
    public class userDB
    {
        [Key]
        public int Id { get; set; }
        [Column("UserName", TypeName = "Varchar(200)")]
        public string UserName { get; set; }
        public int Address { get; set; }
        public int Contact { get; set; }
        public DateOnly? DateRead { get; set; }
    }
}

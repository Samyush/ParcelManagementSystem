using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Database
{
    public class Package
    {
        [Key]
        public int Id { get; set; }
        [Column("PackageName", TypeName = "Varchar(200)")]
        public string PackageName { get; set; }
        public int Qty { get; set; }
        public int PackageCount { get; set; }
        public DateOnly? DateRead { get; set; }
    }
}
    
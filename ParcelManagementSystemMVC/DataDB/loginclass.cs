using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace ParcelManagementSystemMVC.DataDB
{
    public class loginclass
    {

        public int id { get; set; } 
        [Column("username", TypeName = "varchar(30)")]
        public string username { get; set; }    
        public string password { get; set; }    

    }
}

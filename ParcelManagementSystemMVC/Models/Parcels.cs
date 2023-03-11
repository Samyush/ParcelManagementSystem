using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models;

public class Parcels
{
    public int Id { get; set; }
    [Display(Name = "Way Bill Number")]
    public string WayBillNumber { get; set; }
    [Display(Name = "Shipment Status")]
    public string ShipmentStatus { get; set; }
    [Display(Name = "ParcelLocation")]
    public string ParcelLocation { get; set; }
    [ForeignKey("Users.Id")]
    public int ParcelSenderId { get; set; }
    public int ParcelReceiverId{ get; set; }
    
    public Users UserId { get; set; }

    public List<ParcelPackage> Packages { get; set; }
}
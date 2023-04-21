using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models;

public class Parcels :Base
{
    [Key]
    public int Id { get; set; }
    public string ParcelName { get; set; }
    public string ParcelType { get; set; }
    public string ParcelWeight { get; set; }
    public string ParcelSize { get; set; }
    public string ParcelStatus { get; set; }
    public string ParcelLocation { get; set; }
    public string ParcelDestination { get; set; }

    public string ParcelSender { get; set; }
    public string ParcelReceiver { get; set; }
    
    public Users UserId { get; set; }
}
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models;

public class Parcels
{
    [Key]
    public string WayBillNumber { get; set; }
    public DateTime DateCreate { get; set; }= DateTime.Now;
    public string SenderName { get; set; }
    public string SenderAddress { get; set; }
    public string SenderPhone { get; set; }
    public string ReceiverName { get; set; }
    public string ReceiverAddress { get; set; }
    public string ReceiverPhone { get; set; }
    public int NoOfPackets { get; set; }
    public int LorryNo { get; set; }
    public int TinNo { get; set; }
    public string DescriptionofGoods { get; set; }
    public int ActualWeight { get; set; }
    public double ValueofGoods { get; set; }

    //Relationship
    public int UserParcelId { get; set; }
    [ForeignKey("UserParcelId")]
    public Users Users { get; set; }
    

}
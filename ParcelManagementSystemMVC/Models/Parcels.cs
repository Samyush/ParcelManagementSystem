using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models;

public class Parcels
{
    [Key]
    public string WayBillNumber { get; set; }
    public DateTime DateCreate { get; set; }= DateTime.Now;
    public string DeliveryStatus { get; set; }
    public int NoOfPackets { get; set; }
    public int LorryNo { get; set; }
    public int TinNo { get; set; }
    public string DescriptionofGoods { get; set; }
    public int ActualWeight { get; set; }
    public double ValueofGoods { get; set; }

    //Relationship
    public int UserParcelId { get; set; }
    [ForeignKey("UserParcelId")]
    public  Users UserParcel { get; set; }
    public int SenderId { get; set; }
    [ForeignKey("SenderId")]
    public  Users UserSender { get; set; }
    public int ReceiverId { get; set; }
    [ForeignKey("ReceiverId")]
    public  Users UserReceiver { get; set; }


}
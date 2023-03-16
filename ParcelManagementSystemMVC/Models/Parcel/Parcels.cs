using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models.Parcel;

public class Parcels
{
    [Key]
    public int Percel_Id { get; set; }
    public string Way_Bill_Number { get; set; }
    public string Parcel_Name { get; set; }
    public string Parcel_Type { get; set; }
    public string Next_Node { get; set; }
    public DateTime Date_and_Time { get; set; }
    public DateTime Date { get; set; }
    public string Sender_Address { get; set; }
    public string Receiver_Address{ get; set; }
    public string Parcel_Shipment { get; set; }
}
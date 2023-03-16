using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models.Parcel;

public class Parcels
{
    [Key]
    public int Percel_Id { get; set; }
    public string Way_Bill_Number { get; set; }
    public string Parcel_Name { get; set; }
    public string Parcel_Type { get; set; }
    public string Parcel_Location { get; set; }
    public string Parcel_Destination { get; set; }
    public string Next_Node { get; set; }
    public string Sender_Name { get; set; }
    public string Receiver_Name { get; set; }
    public DateTime Date_and_Time { get; set; }
    public DateTime Date { get; set; }
    public string Address_of_Delivery { get; set; }
    public string Status_of_Delivery { get; set; }
    public string Parcel_Shipment { get; set; }
}
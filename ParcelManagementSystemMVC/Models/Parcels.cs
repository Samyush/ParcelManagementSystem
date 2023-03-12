using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models;

public class Parcels
{
    [Key]
    public int Percel_Id { get; set; }
    public string Parcel_Name { get; set; }
    public string Parcel_Type { get; set; }
    public string Parcel_Weight { get; set; }
    public string Parcel_Size { get; set; }
    public string Parcel_Status { get; set; }
    public string Parcel_Location { get; set; }
    public string Parcel_Destination { get; set; }
    public string Parcel_Sender { get; set; }
    public string Parcel_Receiver { get; set; }
    public string Original_Brand { get; set; }
    public DateOnly Date_and_Time { get; set; }
    public string Way_Bill_Number { get; set; }
    public string Address_of_Delivery { get; set; }
    public string Status_of_Delivery { get; set; }
    public int No_of_Packets { get; set; }
    public string Desciption_of_Goods { get; set; }
    public float Actual_Weight { get; set; }
    public string Values_of_Goods { get; set; }
    public string Rate { get; set; }
    public string To_Pay { get; set; }
    public string Due_Paid { get; set; }
    public string Vat { get; set; }
    public string G_Total { get; set; }
    public int Lolary_No { get; set; }
    public int Tin_No { get; set; }
    public int  Branch_Code { get; set; }
    public string Sender_Name { get; set; }
    public string Sender_Address { get;set; }
    public string Sender_Phone_Number { get; set; }
    public string Receiver_Name { get; set; }
    public string Receiver_Address { get; set; }
    public string Receiver_Phone_Number { get; set; }
    public string Status { get; set; }
    public string Location { get; set; }
    public string History_of_Parcel {get;set;}
    public string Actions { get;set; }
}
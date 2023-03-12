namespace ParcelManagementSystemMVC.Models.DTO
{
    public class Add_New_Parceldb
    {

        public DateTime Date_in_Time { get; set; }
        public string Way_Bill_Number { get;set;} 
        public string Sender_Name { get;set;}  
        public string Sender_Address { get;set;}   
        public string Sender_Phone_Number { get;set;}
        public string Receiver_Name { get;set;}
        public string Receiver_Address { get;set;}
        public string Receiver_Phone_Number { get; set;}    
        public int No_of_Packets { get; set; }
        public string Description_of_Goods { get; set;} 
        public float  Actual_Weight { get; set; }
        public string Values_of_Goods { get; set;}  
        public string Rate { get; set; }
        public string To_Pay { get; set; }
        public string Deu_Pay { get; set; }
        public string Vat { get; set; }
        public string G_Total { get; set; }
        public string Lorray_No { get; set; }
        public int Tin_No { get; set; }




    }
}

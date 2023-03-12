namespace ParcelManagementSystemMVC.Models.DTO
{
    public class ParcelListdb
    {

        public string Way_Bill_Number { get; set; } 

        public DateTime Date_in_Time { get; set; }  

        public int Branch_Code { get; set; }        
        public string Sender_Name { get; set; } 
        public string Sender_Address { get; set; }  
        public string Receiver_Address { get; set; }    
        public string Receiver_Name { get; set; }   
        public string Status { get; set; }
        public string Locations { get; set; }       
        public string History_of_Parcel { get; set; }   
        public string Actions { get; set; } 



    }
}

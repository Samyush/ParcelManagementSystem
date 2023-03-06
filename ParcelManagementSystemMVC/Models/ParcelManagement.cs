namespace ParcelManagementSystemMVC.Models
{
    public class ParcelManagement
    {

        public int id {  get; set; }    
        public string Username { get; set; }    
        public string Password { get; set; }  
        

        //setup relationship 
            public int forgot_id { get; set; }
        public forgotpassword forgotpassword { get ; set; } 

      
    }
    
}

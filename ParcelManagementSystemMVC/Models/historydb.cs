using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace ParcelManagementSystemMVC.Models
{
    public class historydb
    {
        [Key]
        public string History_of_Parcel { get; set; }
        public string location { get; set; }
        public string next_node { get; set; }
        public string status { get; set; }
        public DateTime Date { get; set; }
        public DateTime time { get; set; }
        public string  shipment_status {get;set;}
        public string vehicle { get; set; } 
        public  string reason { get; set; }
        public string modified_by { get; set; } 
        public string modified_at { get; set;}
        public string origin { get; set; }  
        public string destination { get; set; } 
        public string document { get; set; }

        public ICollection<Parcels>parcels { get; set; }    



    }
}

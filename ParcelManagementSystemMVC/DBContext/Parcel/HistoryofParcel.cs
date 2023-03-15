using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext.Parcel
{
    public class HistoryofParcel
    {
        [Key]
        public int ID { get; set; }
        public string NextNode { get; set; }
        public string Reason { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedTS { get; set; }
        public string Documents { get; set; }
        public int Parcel_Id { get; set; }
        [ForeignKey("Parcel_Id")]
        public Parcel parcel { get; set; }
    }

}

using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.DBContext.Parcels
{
    public class ParcelHistory
    {
        public string Location { get; set; }
        public string NextNode { get; set; }
        public bool Status { get; set; }
        public DateOnly ParcelData { get; set; }

        [ForeignKey("Location")]
        public Parcel ParcelLocation { get; set; }


    }
}

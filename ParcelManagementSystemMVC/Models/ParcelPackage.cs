using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models
{
    public class ParcelPackage
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Parcels.Id")]
        public int ParcelId { get; set; }
        public int PacketsNumber { get; set; }
        public string Description { get;set; }
        public int AcutalWeight { get; set; }
        public int Value { get; set; }

        public int RateperKg { get; set; }
        public int ToPay { get; set; }

        public int DuePaid { get; set; }

        public int Vat { get; set; }
        public int Gross { 
            get { return Gross; } 
            set { Gross = ToPay + Vat; } }

    }
}

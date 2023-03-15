using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models.DBContext
{
    public class parceltable
    {
        [Key]
        public int ParcelId { get; set; }
        public int parcelbillNo { get; set; }
        public string SenderName { get; set; }

        public string SenderAddress { get; set; }

        public string SenderCity { get; set; }

        public string SenderState { get; set; }

        public string SenderCountry { get; set; }

        public int SenderZipCode { get; set; }

        public string SenderPhone { get; set; }

        public string SenderEmail { get; set; }

        public string RecipientName { get; set; }

        public string RecipientAddress { get; set; }

        public string RecipientCity { get; set; }

        public string RecipientState { get; set; }

        public string RecipientCountry { get; set; }

        public string RecipientZipCode { get; set; }

        public string RecipientPhone { get; set; }

        public string RecipientEmail { get; set; }

        public string Weight { get; set; }

        public string ShippingCost { get; set; }

        public string DeliveryStatus { get; set; }

        public int DeliveryDate { get; set; }

        public int PickupLocationId { get; set; }

        public int UserId { get; set; }

        public int PaymentId { get; set; }
        public string Branch { get; set; }
        public int BranchCode { get; set; }
        public int VehicleNumber { get; set; }


    }
}

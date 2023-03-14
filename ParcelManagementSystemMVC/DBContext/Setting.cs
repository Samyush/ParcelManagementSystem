using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.DBContext
{
    public class Setting
    {
        [Key]
        public int Setting_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string language { get; set; }
        public string FontSize { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

       public string Currency { get; set; }

    }
}

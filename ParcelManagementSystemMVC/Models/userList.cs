using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class userList
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string External { get; set; }
        public string Role { get; set; }
        public string Actions { get; set; }

        public List<Parcels> Parcel { get; set; }

    }
}

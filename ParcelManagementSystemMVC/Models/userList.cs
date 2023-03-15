using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class userList
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string External { get; set; }
        public string Role { get; set; }
        public string Actions { get; set; }

        public Branch Branches { get; set; }
        public Sender Senders { get; set; }
        public Receiver Recievers { get; set; }

        public Role Roles { get; set; }






    }
}

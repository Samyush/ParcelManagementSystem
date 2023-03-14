using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.DBContext
{
    public class AdminUser
    {

        [Key]
        public int User_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Branch { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsExternal { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessRole { get; set; }
        public string Image { get; set; }
    
    }
}

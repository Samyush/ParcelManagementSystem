using System.ComponentModel.DataAnnotations;

<<<<<<<< HEAD:ParcelManagementSystemMVC/DBContext/User/User.cs
namespace ParcelManagementSystemMVC.DBContext.User
========
namespace ParcelManagementSystemMVC.DBContext.Users
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/DBContext/Users/NewUser.cs
{
    public class User
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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelManagementSystemMVC.Models;

public class Users
{
    [Key]
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }    
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string IsExternal { get; set; }
    public string ImageUrl { get; set; }
    //Relationships
    public string BranchCode { get; set; }
    [ForeignKey("BranchCode")]
    public Branch Branch { get; set; }

    public string AccessRole { get; set; }
    [ForeignKey("AccessRole")]
    public Roles Roles { get; set; }
}
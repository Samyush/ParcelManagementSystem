using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace ParcelManagementSystemMVC.Models;

public class Users :Base
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Branch { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public bool IsExternal { get; set; }
    public string UserName { get; set; }
    public string UserPassword { get; set; }
    public string? AccessRole { get; set; }
    public IFormFile Imagefile { get; set; }

    public int branchid { get; set; }
    [ForeignKey("branchid")]
    public Branch branch { get; set; }

}
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;


namespace ParcelManagementSystemMVC.Models;

public class Users
{
    [Key]
    public int User_Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [MaxLength(10), MinLength(10)]
    public string Street { get; set; }
    [Required]
    public string City { get; set; }
    public string State { get; set; }
    public string Acess_Role { get; set; }
    public string Country { get; set; }
    public string Branch { get; set; }
    [Required,MaxLength(10),MinLength(10)]
    public int Phone_number { get; set; }

    [Required]
   public string Email { get; set; }

    [Required]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required"),
     MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    public string Password { get; set; }
    public string Images { get; set; }

    public string New_Password { get; set; }    
    public string Confirm_New_Password { get; set; }    



   

}
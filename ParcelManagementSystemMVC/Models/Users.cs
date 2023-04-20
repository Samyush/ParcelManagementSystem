using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models;

public class Users: Base
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [MaxLength(10), MinLength(10)]
    public string Phone { get; set; }
    [Required]
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string Address { get; set; }
}
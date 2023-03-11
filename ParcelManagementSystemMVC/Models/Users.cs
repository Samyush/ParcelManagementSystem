using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models;

public class Users
{
    [Key]
    public int Id { get; set; }

    [Display(Name ="First Name")]
    [Required(ErrorMessage = "First Name must be entered")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "First Name must be in between 1 and 50 characters")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last Name must be entered")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Last Name must be in between 1 and 50 characters")]
    public string LastName { get; set; }
   

    [Display(Name = "Street")]
    [Required(ErrorMessage = "Street must be entered")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Street must be in between 1 and 50 characters")]
    public string Street { get; set; }

    [Display(Name = "City")]
    [Required(ErrorMessage = "City must be entered")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "City must be in between 1 and 50 characters")]
    public string City { get; set; }

    [Display(Name = "State")]
    [Required(ErrorMessage = "State must be entered")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "State must be in between 1 and 50 characters")]
    public string State { get; set; }
    
    [Display(Name = "Country")]
    [Required(ErrorMessage = "Country must be entered")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Country must be in between 1 and 50 characters")]
    public string Country { get; set; }

    [Display(Name = "Phone Number")]
    [Required(ErrorMessage = "Phone Number must be entered")]
    [MaxLength(10), MinLength(10)]
    public string Phone { get; set; }

    [Required(ErrorMessage ="Must enter a valid email")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    [Display(Name ="Is External")]
    public bool IsExternal { get; set; }

    [Required]
    [Display(Name = "Password")]
    public string Password { get; set; }
    [Display(Name = "Role")]
    public string Role { get; set; }
    
}
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models;

public class RegModel
{
    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; }
    
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }
    
    [Required]
    [Compare("Password", ErrorMessage = "Wrong Password")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassworf { get; set; }
}
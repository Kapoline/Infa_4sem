using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Portfolio.Models;

[Authorize]
public class User : IdentityUser, IUser<string>
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Name { get; set; }
}
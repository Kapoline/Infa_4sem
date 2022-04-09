
using Microsoft.AspNetCore.Identity;

namespace PortfiolioEntity;

public class User : IdentityUser
{
   public int Year { get; set; }
}
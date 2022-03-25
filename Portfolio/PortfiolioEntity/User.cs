using Microsoft.AspNetCore.Identity;

namespace PortfiolioEntity;

public class User : IdentityUser
{
    public string Name { get; set; }
}
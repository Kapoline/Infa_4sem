using Microsoft.EntityFrameworkCore;

namespace PortfiolioEntity;

[Keyless]
public class Entitie
{
    public Guid EntityId { get; set; } 
    public string Tags { get; set; }
    public string Post { get; set; }
    public string PostTags { get; set; }
}
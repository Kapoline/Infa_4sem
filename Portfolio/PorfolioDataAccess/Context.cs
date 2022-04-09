using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfiolioEntity;


namespace PorfolioDataAccess;

public class Context : IdentityDbContext<User>
{
    public DbSet<Request> Requests { get; set; }
    public DbSet<Entitie> Entities { get; set; }
    public Context(DbContextOptions<Context> options): base(options) {}
    
    
}
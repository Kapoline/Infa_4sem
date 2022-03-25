using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfiolioEntity;

namespace PorfolioDataAccess;

public class Context : IdentityDbContext<User>
{
    public Context(DbContextOptions<Context> options): base(options) {}
    
    public DbSet<Request> Requests { get; set; }
}
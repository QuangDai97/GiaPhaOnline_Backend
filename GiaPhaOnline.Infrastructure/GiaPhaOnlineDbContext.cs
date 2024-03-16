using GiaPhaOnline.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace GiaPhaOnline.Infrastructure;

public class GiaPhaOnlineDbContext : DbContext
{
    public GiaPhaOnlineDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FamilyConfiguration());
        modelBuilder.ApplyConfiguration(new PersonConfiguration());
    }
}
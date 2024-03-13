using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaPhaOnline.Domain.EF
{
    public class GiaPhaDbContext : DbContext
    {
        public GiaPhaDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new FamilyConfiguration());
        //    modelBuilder.ApplyConfiguration(new PersonConfiguration());
        //}


        //public virtual DbSet<Person> People { get; set; }
        //public DbSet<Family> Families { get; set; }
    }
}

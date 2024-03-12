using GiaPhaOnline.Domain.Configurations;
using GiaPhaOnline.Domain.Entities;
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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DongHoConfiguration());
            modelBuilder.ApplyConfiguration(new UserInfoConfiguration());
        }


        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<DongHo> DongHos { get; set; }
    }
}

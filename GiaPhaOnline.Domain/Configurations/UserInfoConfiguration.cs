using GiaPhaOnline.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaPhaOnline.Domain.Configurations
{
    public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.ToTable("UserInfos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Dad_ID).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Mother_ID).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.VC_ID).IsRequired().HasDefaultValue(0);
            builder.Property(x=>x.DongHoId).IsRequired();
            builder.HasOne(x => x.DongHo).WithMany(x => x.UserInfos).HasForeignKey(x => x.DongHoId);

        }
    }
}

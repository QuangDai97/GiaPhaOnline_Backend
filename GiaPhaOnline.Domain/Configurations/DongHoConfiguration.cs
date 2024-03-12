using GiaPhaOnline.Domain.Entities;
using GiaPhaOnline.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaPhaOnline.Domain.Configurations
{
    public class DongHoConfiguration : IEntityTypeConfiguration<DongHo>
    {
        public void Configure(EntityTypeBuilder<DongHo> builder)
        {
            builder.ToTable("DongHos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }

    }
}

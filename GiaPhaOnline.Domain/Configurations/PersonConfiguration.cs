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
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DadId).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.MotherId).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.VcId).IsRequired().HasDefaultValue(0);
            builder.Property(x=>x.FamilyId).IsRequired();
            builder.Property(x=>x.Email).IsRequired(false);

            builder.HasOne(x => x.Families).WithMany(x => x.People).HasForeignKey(x => x.FamilyId);

        }
    }
}

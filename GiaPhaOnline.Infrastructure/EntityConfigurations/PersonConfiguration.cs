using GiaPhaOnline.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GiaPhaOnline.Infrastructure.EntityConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DadId).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.MotherId).IsRequired().HasDefaultValue(0);
            builder.Property(x=>x.FamilyId).IsRequired();

            builder.HasOne(x => x.Family).WithMany(x => x.People).HasForeignKey(x => x.FamilyId);

        }
    }
}

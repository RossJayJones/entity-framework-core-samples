using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Samples.Entities;

namespace Samples.TypeConfigurations
{
    public class PersonTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.OwnsOne(p => p.Details, b =>
            {
                b.HasMany(p => p.Addresses).WithOne().OnDelete(DeleteBehavior.Cascade);
                b.HasMany(p => p.Contacts).WithOne().OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}

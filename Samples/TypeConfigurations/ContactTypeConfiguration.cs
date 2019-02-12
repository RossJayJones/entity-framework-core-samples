using EntityFrameworkCoreSamples.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCoreSamples.TypeConfigurations
{
    public class ContactTypeConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property<int>("Id").ValueGeneratedOnAdd();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Samples.Entities;

namespace Samples.TypeConfigurations
{
    public class ContactTypeConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property<int>("Id").ValueGeneratedOnAdd();
        }
    }
}

using EntityFrameworkCoreSamples.Entities;
using EntityFrameworkCoreSamples.TypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreSamples
{
    public class SampleContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sample.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ContactTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PersonTypeConfiguration());
        }
    }
}
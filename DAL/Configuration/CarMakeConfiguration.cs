using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Models;

namespace DAL.Configuration
{
    public class CarMakeConfiguration : IEntityTypeConfiguration<CarMake>
    {
        public void Configure(EntityTypeBuilder<CarMake> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(c => c.Name);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.PhoneNumber).IsUnicode(false).HasMaxLength(30);
            builder.Property(c => c.City).HasMaxLength(50);
            builder.HasQueryFilter(u => !u.IsDeleted);
        }
    }
}
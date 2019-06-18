using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Models;

namespace DAL.Configuration
{
    public class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(c => c.Name);
            builder.HasOne(c => c.CarMake)
                .WithMany(make => make.Models)
                .HasForeignKey(c => c.CarMakeId)
                .HasConstraintName("FK_Model_Make");
            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);
            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
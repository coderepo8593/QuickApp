using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Models;

namespace DAL.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(u => u.Claims).WithOne().HasForeignKey(c => c.UserId).IsRequired();
            builder.HasMany(u => u.Roles).WithOne().HasForeignKey(r => r.UserId).IsRequired();
        }
    }
}
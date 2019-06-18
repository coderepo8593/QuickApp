using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Models;

namespace DAL.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.HasIndex(p => p.Name);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.Icon).IsUnicode(false).HasMaxLength(256);
            builder.HasOne(p => p.Parent).WithMany(p => p.Children).OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.BuyingPrice).HasColumnType(CommonConfigSettings.PriceDecimalType);
            builder.Property(p => p.SellingPrice).HasColumnType(CommonConfigSettings.PriceDecimalType);
        }
    }
}
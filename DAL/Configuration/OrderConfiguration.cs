using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Models;

namespace DAL.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Comments).HasMaxLength(500);
            builder.Property(p => p.Discount).HasColumnType(CommonConfigSettings.PriceDecimalType);
        }
    }
}
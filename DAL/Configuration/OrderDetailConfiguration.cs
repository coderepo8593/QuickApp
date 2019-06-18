using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Models;

namespace DAL.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(p => p.UnitPrice).HasColumnType(CommonConfigSettings.PriceDecimalType);
            builder.Property(p => p.Discount).HasColumnType(CommonConfigSettings.PriceDecimalType);
        }
    }
}

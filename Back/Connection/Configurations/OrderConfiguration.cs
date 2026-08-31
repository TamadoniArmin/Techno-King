using App.Domain.Core.Techno_King.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connection.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x=>x.ShoppingCard)
                .WithOne(x=>x.Order)
                .HasForeignKey<Order>(o => o.ShoppingCardId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(x => x.ShoppingCardId);
        }
    }
}

using App.Domain.Core.Techno_King.Entities.Card;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connection.Configurations
{
    public class ShoppingCardConfiguration : IEntityTypeConfiguration<ShoppingCard>
    {
        public void Configure(EntityTypeBuilder<ShoppingCard> builder)
        {
            builder.HasKey(x=> x.Id);

            builder.HasOne(x=>x.Customer)
                .WithMany(x=>x.ShoppingCards)
                .HasForeignKey(x=>x.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

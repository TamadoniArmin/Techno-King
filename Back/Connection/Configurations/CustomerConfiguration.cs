using App.Domain.Core.Techno_King.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connection.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(new List<Customer>() {
                new Customer {Id = 1} });

            builder.HasOne(c => c.UserBase)
                .WithOne(u => u.Customer)
                .HasForeignKey<UserBase>(u => u.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

using App.Domain.Core.Techno_King.Entities.Card;
using App.Domain.Core.Techno_King.Entities.Catrgories;
using App.Domain.Core.Techno_King.Entities.Comments;
using App.Domain.Core.Techno_King.Entities.Orders;
using App.Domain.Core.Techno_King.Entities.Products;
using App.Domain.Core.Techno_King.Entities.Users;
using Connection.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace Connection.Common
{
    public class AppDbContext : IdentityDbContext<UserBase, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new SuperAdminConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingCardConfiguration());
            UserBaseConfiguration.SeedUsers(modelBuilder);
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<SuperAdmin>().ToTable("SuperAdmin");
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Product>().ToTable("Products");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<SuperAdmin> SuperAdmins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCard> ShoppingCards { get; set; }
    }
}

using App.Domain.Core.Techno_King.Entities.Catrgories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Connection.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Subcategories)
                .WithOne(x => x.ParentCategory)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new List<Category>()
            {
                // ---------------- Parent Categories (ParentId = null) ----------------
                new Category
                {
                    Id = 1,
                    Title = "Smart Devices",
                    Description = "Smart technology, laptops, phones, and tablets",
                    ParentId = null,
                    ImagePath = "images/categories/Smart_Devices.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 2,
                    Title = "Accessories",
                    Description = "Mobile and tech accessories, cases, and audio gear",
                    ParentId = null,
                    ImagePath = "images/categories/Accessories.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 3,
                    Title = "Electronic Gadgets",
                    Description = "Home electronics, speakers, and projectors",
                    ParentId = null,
                    ImagePath = "images/categories/Electronic_Gadgets.jpg",
                    IsDeleted = false
                },

                // ---------------- Subcategories of Smart Devices (ParentId = 1) ----------------
                new Category
                {
                    Id = 4,
                    Title = "Laptops",
                    Description = "Laptops, notebooks, and mobile workstations",
                    ParentId = 1,
                    ImagePath = "images/categories/Laptops.png",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 5,
                    Title = "Mobile Phones",
                    Description = "Smartphones and mobile communication devices",
                    ParentId = 1,
                    ImagePath = "images/categories/Mobile_Phones.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 6,
                    Title = "Tablets",
                    Description = "Touchscreen tablets and smart pads",
                    ParentId = 1,
                    ImagePath = "images/categories/Tablets.jpg",
                    IsDeleted = false
                },

                // ---------------- Subcategories of Accessories (ParentId = 2) ----------------
                new Category
                {
                    Id = 7,
                    Title = "Phone Cases",
                    Description = "Protective covers and phone cases",
                    ParentId = 2,
                    ImagePath = "images/categories/Phone_Cases.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 8,
                    Title = "Headphones & Earphones",
                    Description = "Wireless earbuds, TWS, and over-ear headphones",
                    ParentId = 2,
                    ImagePath = "images/categories/Headphones_&_Earphones.jpg",
                    IsDeleted = false
                },

                // ---------------- Subcategories of Electronic Gadgets (ParentId = 3) ----------------
                new Category
                {
                    Id = 9,
                    Title = "Speakers",
                    Description = "Bluetooth and portable audio speakers",
                    ParentId = 3,
                    ImagePath = "images/categories/Speakers.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 10,
                    Title = "Projectors",
                    Description = "Home cinema and portable smart projectors",
                    ParentId = 3,
                    ImagePath = "images/categories/Projectors.jpg",
                    IsDeleted = false
                }
            });
        }
    }
}
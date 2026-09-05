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
                    Title = "Laptops & Computers",
                    Description = "Laptops, desktop PCs, and computing accessories",
                    ParentId = null,
                    ImagePath = "images/categories/Laptops_&_Computers.png",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 2,
                    Title = "Mobile Phones",
                    Description = "Smartphones and mobile communication devices",
                    ParentId = null,
                    ImagePath = "images/categories/Mobile_Phones.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 3,
                    Title = "Tablets & E-reader",
                    Description = "Touchscreen tablets, smart pads, and e-readers",
                    ParentId = null,
                    ImagePath = "images/categories/Tablets_&_E-reader.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 11,
                    Title = "Wearables",
                    Description = "Smartwatches, fitness bands, and wearable tech",
                    ParentId = null,
                    ImagePath = "images/categories/Wearables.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 12,
                    Title = "Audio",
                    Description = "Headphones, earphones, speakers, and sound systems",
                    ParentId = null,
                    ImagePath = "images/categories/Audio.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 13,
                    Title = "Cameras",
                    Description = "DSLR, mirrorless cameras, action cams, and lenses",
                    ParentId = null,
                    ImagePath = "images/categories/Cameras.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 14,
                    Title = "Gaming",
                    Description = "Gaming consoles, controllers, and gaming gear",
                    ParentId = null,
                    ImagePath = "images/categories/Gaming.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 15,
                    Title = "Networking",
                    Description = "Routers, modems, switches, and network gear",
                    ParentId = null,
                    ImagePath = "images/categories/Networking.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 10,
                    Title = "Accessories",
                    Description = "Tech accessories, cases, cables, and chargers",
                    ParentId = null,
                    ImagePath = "images/categories/Accessories.jpg",
                    IsDeleted = false
                },

                // ---------------- Existing Subcategories ----------------
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
                    Title = "Smartphones",
                    Description = "Android and iOS mobile devices",
                    ParentId = 2,
                    ImagePath = "images/categories/Smartphones.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 6,
                    Title = "Tablets",
                    Description = "Touchscreen tablets and smart pads",
                    ParentId = 3,
                    ImagePath = "images/categories/Tablets.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 7,
                    Title = "Phone Cases",
                    Description = "Protective covers and phone cases",
                    ParentId = 10,
                    ImagePath = "images/categories/Phone_Cases.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 8,
                    Title = "Headphones & Earphones",
                    Description = "Wireless earbuds, TWS, and over-ear headphones",
                    ParentId = 12,
                    ImagePath = "images/categories/Headphones_&_Earphones.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 9,
                    Title = "Speakers",
                    Description = "Bluetooth and portable audio speakers",
                    ParentId = 12,
                    ImagePath = "images/categories/Speakers.jpg",
                    IsDeleted = false
                },

                // ---------------- New Subcategories ----------------
                // Subcategories of Wearables (ParentId = 11)
                new Category
                {
                    Id = 16,
                    Title = "Smartwatches",
                    Description = "Smart fitness and lifestyle watches",
                    ParentId = 11,
                    ImagePath = "images/categories/Smartwatches.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 17,
                    Title = "Fitness Bands",
                    Description = "Activity trackers and health bands",
                    ParentId = 11,
                    ImagePath = "images/categories/Fitness_Bands.jpg",
                    IsDeleted = false
                },

                // Subcategories of Cameras (ParentId = 13)
                new Category
                {
                    Id = 18,
                    Title = "DSLR & Mirrorless",
                    Description = "Professional cameras and interchangeable lenses",
                    ParentId = 13,
                    ImagePath = "images/categories/DSLR_&_Mirrorless.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 19,
                    Title = "Action Cameras",
                    Description = "Compact action cameras and camcorders",
                    ParentId = 13,
                    ImagePath = "images/categories/Action_Cameras.jpg",
                    IsDeleted = false
                },

                // Subcategories of Gaming (ParentId = 14)
                new Category
                {
                    Id = 20,
                    Title = "Gaming Consoles",
                    Description = "PlayStation, Xbox, and Nintendo consoles",
                    ParentId = 14,
                    ImagePath = "images/categories/Gaming_Consoles.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 21,
                    Title = "Gaming Accessories",
                    Description = "Controllers, gamepads, and VR headsets",
                    ParentId = 14,
                    ImagePath = "images/categories/Gaming_Accessories.jpg",
                    IsDeleted = false
                },

                // Subcategories of Networking (ParentId = 15)
                new Category
                {
                    Id = 22,
                    Title = "Wi-Fi Routers",
                    Description = "Wireless routers and Mesh Wi-Fi systems",
                    ParentId = 15,
                    ImagePath = "images/categories/Wi-Fi_Routers.jpg",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 23,
                    Title = "Modems & Switches",
                    Description = "ADSL/VDSL modems and Ethernet network switches",
                    ParentId = 15,
                    ImagePath = "images/categories/Modems_&_Switches.jpg",
                    IsDeleted = false
                }
            });
        }
    }
}
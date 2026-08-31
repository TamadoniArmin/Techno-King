using App.Domain.Core.Techno_King.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Connection.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.SubCategory)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.SubCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.ShoppingCards)
                .WithMany(x => x.SelectedProducts);

            builder.HasData(
                // ---------------- Laptops (SubCategoryId = 4) ----------------
                new Product
                {
                    Id = 1,
                    Name = "Dell XPS 13 Laptop",
                    Price = 25000.00f,
                    Description = "Lightweight and powerful laptop featuring Intel Core i7 processor and 13-inch Full HD display.",
                    Brand = "Dell",
                    DiscountPercentage = 10,
                    SubCategoryId = 4,
                    AverageRating = 4.5f,
                    SalesCount = 120,
                    ImageUrl1 = "images/Products/Dell_XPS_13_Laptop/image_1.png",
                    ImageUrl2 = "images/Products/Dell_XPS_13_Laptop/image_2.png",
                    ImageUrl3 = "images/Products/Dell_XPS_13_Laptop/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 8,
                    Name = "HP Pavilion Gaming Laptop",
                    Price = 22000.00f,
                    Description = "High-performance gaming laptop with RTX 3060 graphics card and 16GB RAM.",
                    Brand = "HP",
                    DiscountPercentage = 25,
                    SubCategoryId = 4,
                    AverageRating = 4.3f,
                    SalesCount = 150,
                    ImageUrl1 = "images/Products/HP_Pavilion_Gaming_Laptop/image_1.jpg",
                    ImageUrl2 = "images/Products/HP_Pavilion_Gaming_Laptop/image_2.jpg",
                    ImageUrl3 = "images/Products/HP_Pavilion_Gaming_Laptop/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 11,
                    Name = "Apple MacBook Pro 16",
                    Price = 35000.00f,
                    Description = "Powered by M3 Max chip with 36GB unified memory and Liquid Retina XDR display.",
                    Brand = "Apple",
                    DiscountPercentage = 0,
                    SubCategoryId = 4,
                    AverageRating = 4.9f,
                    SalesCount = 210,
                    ImageUrl1 = "images/Products/Apple_MacBook_Pro_16/image_1.jpg",
                    ImageUrl2 = "images/Products/Apple_MacBook_Pro_16/image_2.jpg",
                    ImageUrl3 = "images/Products/Apple_MacBook_Pro_16/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 12,
                    Name = "ASUS ROG Zephyrus G14",
                    Price = 28000.00f,
                    Description = "Ultra-portable gaming laptop featuring AMD Ryzen 9 and RTX 4070 GPU.",
                    Brand = "ASUS",
                    DiscountPercentage = 12,
                    SubCategoryId = 4,
                    AverageRating = 4.7f,
                    SalesCount = 95,
                    ImageUrl1 = "images/Products/Asus_ROG_Zephyrus_G14/image_1.jpg",
                    ImageUrl2 = "images/Products/Asus_ROG_Zephyrus_G14/image_2.jpg",
                    ImageUrl3 = "images/Products/Asus_ROG_Zephyrus_G14/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 13,
                    Name = "Lenovo ThinkPad X1 Carbon",
                    Price = 26000.00f,
                    Description = "Business laptop engineered for durability with Intel Core i7 and carbon fiber chassis.",
                    Brand = "Lenovo",
                    DiscountPercentage = 8,
                    SubCategoryId = 4,
                    AverageRating = 4.6f,
                    SalesCount = 180,
                    ImageUrl1 = "images/Products/Lenovo_ThinkPad_X1_Carbon/image_1.png",
                    ImageUrl2 = "images/Products/Lenovo_ThinkPad_X1_Carbon/image_2.png",
                    ImageUrl3 = "images/Products/Lenovo_ThinkPad_X1_Carbon/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 14,
                    Name = "Acer Swift 3",
                    Price = 14000.00f,
                    Description = "Affordable and sleek laptop equipped with AMD Ryzen 7 processor for daily tasks.",
                    Brand = "Acer",
                    DiscountPercentage = 15,
                    SubCategoryId = 4,
                    AverageRating = 4.2f,
                    SalesCount = 310,
                    ImageUrl1 = "images/Products/Acer_Swift_3/image_1.jpg",
                    ImageUrl2 = "images/Products/Acer_Swift_3/image_2.png",
                    ImageUrl3 = "images/Products/Acer_Swift_3/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 15,
                    Name = "Microsoft Surface Laptop 5",
                    Price = 21000.00f,
                    Description = "Elegant touchscreen laptop with PixelSense display and long-lasting battery life.",
                    Brand = "Microsoft",
                    DiscountPercentage = 5,
                    SubCategoryId = 4,
                    AverageRating = 4.4f,
                    SalesCount = 115,
                    ImageUrl1 = "images/Products/Microsoft_Surface_Laptop_5/image_1.jpg",
                    ImageUrl2 = "images/Products/Microsoft_Surface_Laptop_5/image_2.webp",
                    ImageUrl3 = "images/Products/Microsoft_Surface_Laptop_5/image_3.webp",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 16,
                    Name = "Razer Blade 15",
                    Price = 38000.00f,
                    Description = "Premium gaming laptop featuring OLED 240Hz display and NVIDIA RTX 4080.",
                    Brand = "Razer",
                    DiscountPercentage = 7,
                    SubCategoryId = 4,
                    AverageRating = 4.8f,
                    SalesCount = 75,
                    ImageUrl1 = "images/Products/Razer_Blade_15/image_1.jpg",
                    ImageUrl2 = "images/Products/Razer_Blade_15/image_2.jpg",
                    ImageUrl3 = "images/Products/Razer_Blade_15/image_3.jpg",
                    IsDeleted = false
                },

                // ---------------- Mobile Phones (SubCategoryId = 5) ----------------
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S24",
                    Price = 18000.00f,
                    Description = "Flagship smartphone featuring 200MP camera and 5000mAh long-lasting battery.",
                    Brand = "Samsung",
                    DiscountPercentage = 5,
                    SubCategoryId = 5,
                    AverageRating = 4.8f,
                    SalesCount = 450,
                    ImageUrl1 = "images/Products/Samsung_Galaxy_S24_Ultra/image_1.jpg",
                    ImageUrl2 = "images/Products/Samsung_Galaxy_S24_Ultra/image_2.png",
                    ImageUrl3 = "images/Products/Samsung_Galaxy_S24_Ultra/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 9,
                    Name = "iPhone 15 Pro",
                    Price = 32000.00f,
                    Description = "Pro iPhone powered by A17 Pro chip and triple 48MP camera system.",
                    Brand = "Apple",
                    DiscountPercentage = 5,
                    SubCategoryId = 5,
                    AverageRating = 4.9f,
                    SalesCount = 280,
                    ImageUrl1 = "images/Products/iPhone_15_Pro/image_1.jpg",
                    ImageUrl2 = "images/Products/iPhone_15_Pro/image_2.jpg",
                    ImageUrl3 = "images/Products/iPhone_15_Pro/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 17,
                    Name = "Google Pixel 8 Pro",
                    Price = 20000.00f,
                    Description = "Advanced AI camera system powered by Google Tensor G3 chip.",
                    Brand = "Google",
                    DiscountPercentage = 10,
                    SubCategoryId = 5,
                    AverageRating = 4.6f,
                    SalesCount = 330,
                    ImageUrl1 = "images/Products/Google_Pixel_8_Pro/image_1.jpg",
                    ImageUrl2 = "images/Products/Google_Pixel_8_Pro/image_2.jpg",
                    ImageUrl3 = "images/Products/Google_Pixel_8_Pro/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 18,
                    Name = "Xiaomi 13 Ultra",
                    Price = 17000.00f,
                    Description = "Professional photography phone co-engineered with Leica quad-camera setup.",
                    Brand = "Xiaomi",
                    DiscountPercentage = 12,
                    SubCategoryId = 5,
                    AverageRating = 4.5f,
                    SalesCount = 520,
                    ImageUrl1 = "images/Products/Xiaomi_13_Ultra/image_1.jpg",
                    ImageUrl2 = "images/Products/Xiaomi_13_Ultra/image_2.jpg",
                    ImageUrl3 = "images/Products/Xiaomi_13_Ultra/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 19,
                    Name = "OnePlus 12",
                    Price = 16000.00f,
                    Description = "Fast performance phone with Snapdragon 8 Gen 3 and 100W SUPERVOOC charging.",
                    Brand = "OnePlus",
                    DiscountPercentage = 8,
                    SubCategoryId = 5,
                    AverageRating = 4.7f,
                    SalesCount = 290,
                    ImageUrl1 = "images/Products/OnePlus_12/image_1.png",
                    ImageUrl2 = "images/Products/OnePlus_12/image_2.png",
                    ImageUrl3 = "images/Products/OnePlus_12/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 20,
                    Name = "Sony Xperia 1 V",
                    Price = 24000.00f,
                    Description = "Designed for content creators with 4K HDR OLED display and Exmor T sensor.",
                    Brand = "Sony",
                    DiscountPercentage = 0,
                    SubCategoryId = 5,
                    AverageRating = 4.3f,
                    SalesCount = 80,
                    ImageUrl1 = "images/Products/Sony_Xperia_1_V/image_1.webp",
                    ImageUrl2 = "images/Products/Sony_Xperia_1_V/image_2.jpg",
                    ImageUrl3 = "images/Products/Sony_Xperia_1_V/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 21,
                    Name = "Samsung Galaxy Z Fold 5",
                    Price = 36000.00f,
                    Description = "Foldable screen device with multi-tasking capabilities and S Pen support.",
                    Brand = "Samsung",
                    DiscountPercentage = 15,
                    SubCategoryId = 5,
                    AverageRating = 4.4f,
                    SalesCount = 140,
                    ImageUrl1 = "images/Products/Samsung_Galaxy_Z_Fold_5/image_1.jpg",
                    ImageUrl2 = "images/Products/Samsung_Galaxy_Z_Fold_5/image_2.jpg",
                    ImageUrl3 = "images/Products/Samsung_Galaxy_Z_Fold_5/image_3.png",
                    IsDeleted = false
                },

                // ---------------- Tablets (SubCategoryId = 6) ----------------
                new Product
                {
                    Id = 3,
                    Name = "iPad Air",
                    Price = 15000.00f,
                    Description = "Apple tablet powered by M2 chip featuring a 10.9-inch Liquid Retina display.",
                    Brand = "Apple",
                    DiscountPercentage = 0,
                    SubCategoryId = 6,
                    AverageRating = 4.7f,
                    SalesCount = 85,
                    ImageUrl1 = "images/Products/iPad_Air_M2/image_1.jpg",
                    ImageUrl2 = "images/Products/iPad_Air_M2/image_2.jpg",
                    ImageUrl3 = "images/Products/iPad_Air_M2/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 22,
                    Name = "Samsung Galaxy Tab S9 Ultra",
                    Price = 23000.00f,
                    Description = "Massive 14.6-inch Dynamic AMOLED 2X display with IP68 water resistance.",
                    Brand = "Samsung",
                    DiscountPercentage = 10,
                    SubCategoryId = 6,
                    AverageRating = 4.8f,
                    SalesCount = 110,
                    ImageUrl1 = "images/Products/Samsung_Galaxy_Tab_S9_Ultra/image_1.jpg",
                    ImageUrl2 = "images/Products/Samsung_Galaxy_Tab_S9_Ultra/image_2.jpg",
                    ImageUrl3 = "images/Products/Samsung_Galaxy_Tab_S9_Ultra/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 23,
                    Name = "iPad Pro 12.9 M2",
                    Price = 29000.00f,
                    Description = "Ultimate iPad experience with XDR display, ProMotion technology, and Thunderbolt support.",
                    Brand = "Apple",
                    DiscountPercentage = 5,
                    SubCategoryId = 6,
                    AverageRating = 4.9f,
                    SalesCount = 200,
                    ImageUrl1 = "images/Products/iPad_Pro_12.9_M2/image_1.webp",
                    ImageUrl2 = "images/Products/iPad_Pro_12.9_M2/image_2.jpg",
                    ImageUrl3 = "images/Products/iPad_Pro_12.9_M2/image_3.png",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 24,
                    Name = "Lenovo Tab P12 Pro",
                    Price = 12000.00f,
                    Description = "Versatile Android tablet featuring 120Hz AMOLED display and JBL quad speakers.",
                    Brand = "Lenovo",
                    DiscountPercentage = 18,
                    SubCategoryId = 6,
                    AverageRating = 4.2f,
                    SalesCount = 90,
                    ImageUrl1 = "images/Products/Lenovo_Tab_P12_Pro/image_1.jpg",
                    ImageUrl2 = "images/Products/Lenovo_Tab_P12_Pro/image_2.png",
                    ImageUrl3 = "images/Products/Lenovo_Tab_P12_Pro/image_3.png",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 25,
                    Name = "Microsoft Surface Pro 9",
                    Price = 24000.00f,
                    Description = "2-in-1 tablet/laptop hybrid running full Windows 11 operating system.",
                    Brand = "Microsoft",
                    DiscountPercentage = 8,
                    SubCategoryId = 6,
                    AverageRating = 4.5f,
                    SalesCount = 160,
                    ImageUrl1 = "images/Products/Microsoft_Surface_Pro_9/image_1.jpg",
                    ImageUrl2 = "images/Products/Microsoft_Surface_Pro_9/image_2.jpg",
                    ImageUrl3 = "images/Products/Microsoft_Surface_Pro_9/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 26,
                    Name = "Xiaomi Pad 6",
                    Price = 8500.00f,
                    Description = "Budget-friendly tablet featuring 144Hz WQHD+ display and Snapdragon 870.",
                    Brand = "Xiaomi",
                    DiscountPercentage = 12,
                    SubCategoryId = 6,
                    AverageRating = 4.4f,
                    SalesCount = 410,
                    ImageUrl1 = "images/Products/Xiaomi_Pad_6/image_1.jpg",
                    ImageUrl2 = "images/Products/Xiaomi_Pad_6/image_2.png",
                    ImageUrl3 = "images/Products/Xiaomi_Pad_6/image_3.jpg",
                    IsDeleted = false
                },

                // ---------------- Phone Cases (SubCategoryId = 7) ----------------
                new Product
                {
                    Id = 4,
                    Name = "Spigen Protective Phone Case",
                    Price = 500.00f,
                    Description = "Shockproof and scratch-resistant smartphone case with ergonomic grip design.",
                    Brand = "Spigen",
                    DiscountPercentage = 15,
                    SubCategoryId = 7,
                    AverageRating = 4.2f,
                    SalesCount = 1200,
                    ImageUrl1 = "images/Products/Spigen_Protective_Phone_Case/image_1.jpg",
                    ImageUrl2 = "images/Products/Spigen_Protective_Phone_Case/image_2.jpg",
                    ImageUrl3 = "images/Products/Spigen_Protective_Phone_Case/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 10,
                    Name = "OtterBox Defender Case",
                    Price = 700.00f,
                    Description = "Heavy-duty rugged case built for extreme durability and drop protection.",
                    Brand = "OtterBox",
                    DiscountPercentage = 18,
                    SubCategoryId = 7,
                    AverageRating = 4.0f,
                    SalesCount = 850,
                    ImageUrl1 = "images/Products/OtterBox_Defender_Case/image_1.jpg",
                    ImageUrl2 = "images/Products/OtterBox_Defender_Case/image_2.jpg",
                    ImageUrl3 = "images/Products/OtterBox_Defender_Case/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 27,
                    Name = "Apple Leather Case with MagSafe",
                    Price = 1200.00f,
                    Description = "Specially tanned leather cover with built-in magnets for fast wireless charging.",
                    Brand = "Apple",
                    DiscountPercentage = 0,
                    SubCategoryId = 7,
                    AverageRating = 4.3f,
                    SalesCount = 670,
                    ImageUrl1 = "images/Products/Apple_Leather_Case_with_MagSafe/image_1.jpg",
                    ImageUrl2 = "images/Products/Apple_Leather_Case_with_MagSafe/image_2.jpg",
                    ImageUrl3 = "images/Products/Apple_Leather_Case_with_MagSafe/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 28,
                    Name = "UAG Monarch Rugged Case",
                    Price = 900.00f,
                    Description = "Multi-layer protective armor case passing double military drop test standards.",
                    Brand = "UAG",
                    DiscountPercentage = 10,
                    SubCategoryId = 7,
                    AverageRating = 4.6f,
                    SalesCount = 390,
                    ImageUrl1 = "images/Products/UAG_Monarch_Rugged_Case/image_1.jpg",
                    ImageUrl2 = "images/Products/UAG_Monarch_Rugged_Case/image_2.jpg",
                    ImageUrl3 = "images/Products/UAG_Monarch_Rugged_Case/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 29,
                    Name = "ESR Clear Silicone Case",
                    Price = 300.00f,
                    Description = "Ultra-thin transparent case with yellowing-resistant TPU material.",
                    Brand = "ESR",
                    DiscountPercentage = 20,
                    SubCategoryId = 7,
                    AverageRating = 4.1f,
                    SalesCount = 1500,
                    ImageUrl1 = "images/Products/ESR_Clear_Silicone_Case/image_1.jpg",
                    ImageUrl2 = "images/Products/ESR_Clear_Silicone_Case/image_2.jpg",
                    ImageUrl3 = "images/Products/ESR_Clear_Silicone_Case/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 30,
                    Name = "Nillkin CamShield Case",
                    Price = 450.00f,
                    Description = "Slim protective cover equipped with a sliding lens cover for privacy and safety.",
                    Brand = "Nillkin",
                    DiscountPercentage = 5,
                    SubCategoryId = 7,
                    AverageRating = 4.4f,
                    SalesCount = 780,
                    ImageUrl1 = "images/Products/Nillkin_CamShield_Case/image_1.jpg",
                    ImageUrl2 = "images/Products/Nillkin_CamShield_Case/image_2.jpg",
                    ImageUrl3 = "images/Products/Nillkin_CamShield_Case/image_3.jpg",
                    IsDeleted = false
                },

                // ---------------- Headphones & Earphones (SubCategoryId = 8) ----------------
                new Product
                {
                    Id = 5,
                    Name = "AirPods Pro Wireless Earbuds",
                    Price = 8000.00f,
                    Description = "Apple wireless earbuds featuring Active Noise Cancellation and 6-hour battery life.",
                    Brand = "Apple",
                    DiscountPercentage = 20,
                    SubCategoryId = 8,
                    AverageRating = 4.9f,
                    SalesCount = 600,
                    ImageUrl1 = "images/Products/AirPods_Pro_Wireless_Earbuds/image_1.jpg",
                    ImageUrl2 = "images/Products/AirPods_Pro_Wireless_Earbuds/image_2.jpg",
                    ImageUrl3 = "images/Products/AirPods_Pro_Wireless_Earbuds/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 31,
                    Name = "Sony WH-1000XM5 Headphones",
                    Price = 11000.00f,
                    Description = "Industry-leading noise-canceling over-ear headphones with superior call quality.",
                    Brand = "Sony",
                    DiscountPercentage = 10,
                    SubCategoryId = 8,
                    AverageRating = 4.8f,
                    SalesCount = 890,
                    ImageUrl1 = "images/Products/Sony_WH-1000XM5_Headphones/image_1.webp",
                    ImageUrl2 = "images/Products/Sony_WH-1000XM5_Headphones/image_2.jpg",
                    ImageUrl3 = "images/Products/Sony_WH-1000XM5_Headphones/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 32,
                    Name = "Sennheiser Momentum 4 Wireless",
                    Price = 10000.00f,
                    Description = "Audiophile-grade sound quality paired with an exceptional 60-hour battery runtime.",
                    Brand = "Sennheiser",
                    DiscountPercentage = 15,
                    SubCategoryId = 8,
                    AverageRating = 4.6f,
                    SalesCount = 340,
                    ImageUrl1 = "images/Products/Sennheiser_Momentum_4_Wireless/image_1.jpg",
                    ImageUrl2 = "images/Products/Sennheiser_Momentum_4_Wireless/image_2.jpg",
                    ImageUrl3 = "images/Products/Sennheiser_Momentum_4_Wireless/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 33,
                    Name = "Bose QuietComfort Earbuds II",
                    Price = 9000.00f,
                    Description = "Personalized noise cancellation and sound performance with CustomTune technology.",
                    Brand = "Bose",
                    DiscountPercentage = 5,
                    SubCategoryId = 8,
                    AverageRating = 4.7f,
                    SalesCount = 420,
                    ImageUrl1 = "images/Products/Bose_QuietComfort_Earbuds_II/image_1.png",
                    ImageUrl2 = "images/Products/Bose_QuietComfort_Earbuds_II/image_2.png",
                    ImageUrl3 = "images/Products/Bose_QuietComfort_Earbuds_II/image_3.png",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 34,
                    Name = "Anker Soundcore Liberty 4",
                    Price = 3500.00f,
                    Description = "Budget TWS earbuds with heart rate sensor, spatial audio, and LDAC support.",
                    Brand = "Anker",
                    DiscountPercentage = 25,
                    SubCategoryId = 8,
                    AverageRating = 4.3f,
                    SalesCount = 980,
                    ImageUrl1 = "images/Products/Anker_Soundcore_Liberty_4/image_1.jpg",
                    ImageUrl2 = "images/Products/Anker_Soundcore_Liberty_4/image_2.png",
                    ImageUrl3 = "images/Products/Anker_Soundcore_Liberty_4/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 35,
                    Name = "Galaxy Buds 2 Pro",
                    Price = 6500.00f,
                    Description = "Hi-Fi 24-bit audio earbuds featuring intelligent 360 audio and ergonomic fit.",
                    Brand = "Samsung",
                    DiscountPercentage = 12,
                    SubCategoryId = 8,
                    AverageRating = 4.5f,
                    SalesCount = 510,
                    ImageUrl1 = "images/Products/Galaxy_Buds_2_Pro/image_1.jpg",
                    ImageUrl2 = "images/Products/Galaxy_Buds_2_Pro/image_2.jpg",
                    ImageUrl3 = "images/Products/Galaxy_Buds_2_Pro/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 36,
                    Name = "JBL Tune 760NC",
                    Price = 2800.00f,
                    Description = "Lightweight wireless over-ear headphones with Active Noise Cancelling and Pure Bass.",
                    Brand = "JBL",
                    DiscountPercentage = 18,
                    SubCategoryId = 8,
                    AverageRating = 4.2f,
                    SalesCount = 630,
                    ImageUrl1 = "images/Products/JBL_Tune_760NC/image_1.jpg",
                    ImageUrl2 = "images/Products/JBL_Tune_760NC/image_2.jpg",
                    ImageUrl3 = "images/Products/JBL_Tune_760NC/image_3.jpg",
                    IsDeleted = false
                },

                // ---------------- Speakers (SubCategoryId = 9) ----------------
                new Product
                {
                    Id = 6,
                    Name = "JBL Charge 5 Speaker",
                    Price = 6000.00f,
                    Description = "Waterproof Bluetooth speaker with 20-hour power bank capacity and 360-degree audio.",
                    Brand = "JBL",
                    DiscountPercentage = 8,
                    SubCategoryId = 9,
                    AverageRating = 4.4f,
                    SalesCount = 310,
                    ImageUrl1 = "images/Products/JBL_Charge_5_Speaker/image_1.png",
                    ImageUrl2 = "images/Products/JBL_Charge_5_Speaker/image_2.jpg",
                    ImageUrl3 = "images/Products/JBL_Charge_5_Speaker/image_3.png",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 37,
                    Name = "Marshall Acton III Bluetooth Speaker",
                    Price = 9500.00f,
                    Description = "Iconic vintage-style home speaker delivering room-filling stereo sound.",
                    Brand = "Marshall",
                    DiscountPercentage = 5,
                    SubCategoryId = 9,
                    AverageRating = 4.7f,
                    SalesCount = 230,
                    ImageUrl1 = "images/Products/Marshall_Acton_III_Bluetooth_Speaker/image_1.jpg",
                    ImageUrl2 = "images/Products/Marshall_Acton_III_Bluetooth_Speaker/image_2.jpg",
                    ImageUrl3 = "images/Products/Marshall_Acton_III_Bluetooth_Speaker/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 38,
                    Name = "Sonos Roam Portable Speaker",
                    Price = 5500.00f,
                    Description = "Smart portable speaker with Wi-Fi and Bluetooth connectivity and Automatic Trueplay.",
                    Brand = "Sonos",
                    DiscountPercentage = 10,
                    SubCategoryId = 9,
                    AverageRating = 4.3f,
                    SalesCount = 190,
                    ImageUrl1 = "images/Products/Sonos_Roam_Portable_Speaker/image_1.jpg",
                    ImageUrl2 = "images/Products/Sonos_Roam_Portable_Speaker/image_2.jpg",
                    ImageUrl3 = "images/Products/Sonos_Roam_Portable_Speaker/image_3.webp",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 39,
                    Name = "Harman Kardon Aura Studio 4",
                    Price = 11000.00f,
                    Description = "Transparent dome Bluetooth speaker featuring ambient lighting patterns and 360-degree sound.",
                    Brand = "Harman Kardon",
                    DiscountPercentage = 0,
                    SubCategoryId = 9,
                    AverageRating = 4.8f,
                    SalesCount = 140,
                    ImageUrl1 = "images/Products/Harman_Kardon_Aura_Studio_4/image_1.png",
                    ImageUrl2 = "images/Products/Harman_Kardon_Aura_Studio_4/image_2.jpg",
                    ImageUrl3 = "images/Products/Harman_Kardon_Aura_Studio_4/image_3.png",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 40,
                    Name = "Bose SoundLink Flex",
                    Price = 4800.00f,
                    Description = "Rugged outdoor Bluetooth speaker designed with PositionIQ technology and dust resistance.",
                    Brand = "Bose",
                    DiscountPercentage = 12,
                    SubCategoryId = 9,
                    AverageRating = 4.6f,
                    SalesCount = 410,
                    ImageUrl1 = "images/Products/Bose_SoundLink_Flex/image_1.webp",
                    ImageUrl2 = "images/Products/Bose_SoundLink_Flex/image_2.jpg",
                    ImageUrl3 = "images/Products/Bose_SoundLink_Flex/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 41,
                    Name = "Anker Soundcore Motion+",
                    Price = 3200.00f,
                    Description = "Hi-Res 30W portable Bluetooth speaker with Qualcomm aptX audio technology.",
                    Brand = "Anker",
                    DiscountPercentage = 15,
                    SubCategoryId = 9,
                    AverageRating = 4.5f,
                    SalesCount = 760,
                    ImageUrl1 = "images/Products/Anker_Soundcore_Motion+/image_1.jpg",
                    ImageUrl2 = "images/Products/Anker_Soundcore_Motion+/image_2.jpg",
                    ImageUrl3 = "images/Products/Anker_Soundcore_Motion+/image_3.webp",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 42,
                    Name = "Ultimate Ears MEGABOOM 3",
                    Price = 6200.00f,
                    Description = "Powerful wireless Bluetooth speaker with deep bass, one-touch control, and IP67 rating.",
                    Brand = "Ultimate Ears",
                    DiscountPercentage = 20,
                    SubCategoryId = 9,
                    AverageRating = 4.4f,
                    SalesCount = 280,
                    ImageUrl1 = "images/Products/Ultimate_Ears_MEGABOOM_3/image_1.jpg",
                    ImageUrl2 = "images/Products/Ultimate_Ears_MEGABOOM_3/image_2.jpg",
                    ImageUrl3 = "images/Products/Ultimate_Ears_MEGABOOM_3/image_3.jpg",
                    IsDeleted = false
                },

                // ---------------- Projectors (SubCategoryId = 10) ----------------
                new Product
                {
                    Id = 7,
                    Name = "Epson Home Cinema Projector",
                    Price = 12000.00f,
                    Description = "Home theater projector featuring 4K resolution capabilities and 3000 lumens brightness.",
                    Brand = "Epson",
                    DiscountPercentage = 12,
                    SubCategoryId = 10,
                    AverageRating = 4.1f,
                    SalesCount = 45,
                    ImageUrl1 = "images/Products/Epson_Home_Cinema_Projector/image_1.jpg",
                    ImageUrl2 = "images/Products/Epson_Home_Cinema_Projector/image_2.jpg",
                    ImageUrl3 = "images/Products/Epson_Home_Cinema_Projector/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 43,
                    Name = "Anker Nebula Capsule 3",
                    Price = 18000.00f,
                    Description = "Soda-can sized mini smart projector with Google TV and 1080p Laser display.",
                    Brand = "Anker",
                    DiscountPercentage = 10,
                    SubCategoryId = 10,
                    AverageRating = 4.6f,
                    SalesCount = 125,
                    ImageUrl1 = "images/Products/Anker_Nebula_Capsule_3/image_1.jpg",
                    ImageUrl2 = "images/Products/Anker_Nebula_Capsule_3/image_2.jpg",
                    ImageUrl3 = "images/Products/Anker_Nebula_Capsule_3/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 44,
                    Name = "XGIMI Horizon Pro 4K",
                    Price = 34000.00f,
                    Description = "Premium home projector with Harman Kardon speakers and Intelligent Screen Adaptation.",
                    Brand = "XGIMI",
                    DiscountPercentage = 8,
                    SubCategoryId = 10,
                    AverageRating = 4.8f,
                    SalesCount = 95,
                    ImageUrl1 = "images/Products/XGIMI_Horizon_Pro_4K/image_1.png",
                    ImageUrl2 = "images/Products/XGIMI_Horizon_Pro_4K/image_2.jpg",
                    ImageUrl3 = "images/Products/XGIMI_Horizon_Pro_4K/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 45,
                    Name = "BenQ TH585P Gaming Projector",
                    Price = 16000.00f,
                    Description = "Low input lag Full HD projector designed for console gaming and sports viewing.",
                    Brand = "BenQ",
                    DiscountPercentage = 15,
                    SubCategoryId = 10,
                    AverageRating = 4.3f,
                    SalesCount = 80,
                    ImageUrl1 = "images/Products/BenQ_TH585P_Gaming_Projector/image_1.webp",
                    ImageUrl2 = "images/Products/BenQ_TH585P_Gaming_Projector/image_2.jpg",
                    ImageUrl3 = "images/Products/BenQ_TH585P_Gaming_Projector/image_3.webp",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 46,
                    Name = "Samsung The Freestyle Gen 2",
                    Price = 21000.00f,
                    Description = "Portable smart projector with 180-degree cradle design and Gaming Hub support.",
                    Brand = "Samsung",
                    DiscountPercentage = 5,
                    SubCategoryId = 10,
                    AverageRating = 4.2f,
                    SalesCount = 210,
                    ImageUrl1 = "images/Products/Samsung_The_Freestyle_Gen_2/image_1.webp",
                    ImageUrl2 = "images/Products/Samsung_The_Freestyle_Gen_2/image_2.png",
                    ImageUrl3 = "images/Products/Samsung_The_Freestyle_Gen_2/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 47,
                    Name = "LG CineBeam PF50KA",
                    Price = 14500.00f,
                    Description = "Compact Smart TV LED projector with built-in battery lasting up to 2.5 hours.",
                    Brand = "LG",
                    DiscountPercentage = 10,
                    SubCategoryId = 10,
                    AverageRating = 4.1f,
                    SalesCount = 65,
                    ImageUrl1 = "images/Products/LG_CineBeam_PF50KA/image_1.jpg",
                    ImageUrl2 = "images/Products/LG_CineBeam_PF50KA/image_2.jpg",
                    ImageUrl3 = "images/Products/LG_CineBeam_PF50KA/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 48,
                    Name = "ViewSonic M2e Smart Projector",
                    Price = 13000.00f,
                    Description = "Instant auto-focus 1080p LED portable projector with Harman Kardon speakers.",
                    Brand = "ViewSonic",
                    DiscountPercentage = 18,
                    SubCategoryId = 10,
                    AverageRating = 4.4f,
                    SalesCount = 110,
                    ImageUrl1 = "images/Products/ViewSonic_M2e_Smart_Projector/image_1.jpg",
                    ImageUrl2 = "images/Products/ViewSonic_M2e_Smart_Projector/image_2.jpg",
                    ImageUrl3 = "images/Products/ViewSonic_M2e_Smart_Projector/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 49,
                    Name = "Optoma HD146X High Performance",
                    Price = 15500.00f,
                    Description = "Home theater projector with Enhanced Gaming Mode and 3600 lumens brightness.",
                    Brand = "Optoma",
                    DiscountPercentage = 7,
                    SubCategoryId = 10,
                    AverageRating = 4.0f,
                    SalesCount = 135,
                    ImageUrl1 = "images/Products/Optoma_HD146X_High_Performance/image_1.jpg",
                    ImageUrl2 = "images/Products/Optoma_HD146X_High_Performance/image_2.jpg",
                    ImageUrl3 = "images/Products/Optoma_HD146X_High_Performance/image_3.jpg",
                    IsDeleted = false
                },
                new Product
                {
                    Id = 50,
                    Name = "Wanbo T2 Max Portable Projector",
                    Price = 5000.00f,
                    Description = "Mini LCD projector with native 1080p support and fully enclosed optical engine.",
                    Brand = "Wanbo",
                    DiscountPercentage = 20,
                    SubCategoryId = 10,
                    AverageRating = 3.9f,
                    SalesCount = 310,
                    ImageUrl1 = "images/Products/Wanbo_T2_Max_Portable_Projector/image_1.png",
                    ImageUrl2 = "images/Products/Wanbo_T2_Max_Portable_Projector/image_2.jpg",
                    ImageUrl3 = "images/Products/Wanbo_T2_Max_Portable_Projector/image_3.jpg",
                    IsDeleted = false
                }
            );
        }
    }
}
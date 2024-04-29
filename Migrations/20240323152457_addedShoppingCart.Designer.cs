﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolovniAutomobiliMVC.Models;

#nullable disable

namespace PolovniAutomobiliMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240323152457_addedShoppingCart")]
    partial class addedShoppingCart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descriptionShort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fuelTypeId")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrlThumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isSpecialOffer")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.HasIndex("fuelTypeId");

                    b.ToTable("cars");

                    b.HasData(
                        new
                        {
                            id = 1,
                            categoryId = 3,
                            description = "When an SUV delivers as crisp a driving experience as the 2022 Hyundai Kona, it's hard to get hung up on the usual anti-crossover sentiment—so we won't. The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position. Two four-cylinder engines are offered: a 2.0-liter four, which is admittedly pretty poky, and a more desirable turbocharged 1.6-liter four that delivers a lot more punch.",
                            descriptionShort = "The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position.",
                            fuelTypeId = 1,
                            imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=980:*",
                            imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=980:*",
                            isSpecialOffer = false,
                            name = "Hyundai Kona",
                            price = 22135m
                        },
                        new
                        {
                            id = 2,
                            categoryId = 3,
                            description = "With a bold exterior look and a surprisingly spacious cabin, the 2021 Nissan Kicks is a stylish small SUV with a practical side. Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick. Standard equipment is plentiful and includes driver-assistance features and popular infotainment tech such as Apple CarPlay and Android Auto.",
                            descriptionShort = "Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick.",
                            fuelTypeId = 2,
                            imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=2048:*",
                            imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=800:*",
                            isSpecialOffer = true,
                            name = "Nissan Kicks",
                            price = 20650m
                        },
                        new
                        {
                            id = 3,
                            categoryId = 2,
                            description = "Few compact hatchbacks are better than the 2021 Volkswagen Golf, but one that is happens to share the same showroom: the sporty GTI (reviewed separately). Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. While that's partly why VW will only offer the next-generation GTI and high-performance Golf R on our shores, it doesn't diminish that the regular version remains a terrific value in its final year.",
                            descriptionShort = "Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. ",
                            fuelTypeId = 1,
                            imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=2048:*",
                            imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=800:*",
                            isSpecialOffer = false,
                            name = "VW Golf",
                            price = 24190m
                        },
                        new
                        {
                            id = 4,
                            categoryId = 3,
                            description = "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. It's available in both standard-length and long-wheelbase Expedition Max body styles and is powered by a twin-turbocharged V-6 engine with a 10-speed automatic transmission. Rear-wheel drive is standard, but buyers who need four-wheel action can have it on any trim level for a price.",
                            descriptionShort = "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. ",
                            fuelTypeId = 2,
                            imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=2048:*",
                            imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=800:*",
                            isSpecialOffer = false,
                            name = "Ford Expedition",
                            price = 51690m
                        },
                        new
                        {
                            id = 5,
                            categoryId = 2,
                            description = "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxesS—but they're surprisingly more sophisticated than that. So much so that we named the Rio to our Editors' Choice list. The Kia couple shares a cabin design that exudes an elegant simplicity thanks to a smart layout and pleasing materials.",
                            descriptionShort = "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxes—but they're surprisingly more sophisticated than that.",
                            fuelTypeId = 1,
                            imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=2048:*",
                            imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=800:*",
                            isSpecialOffer = true,
                            name = "Kia Rio",
                            price = 17045m
                        },
                        new
                        {
                            id = 6,
                            categoryId = 1,
                            description = "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car. Available as either a four-door hatchback or sedan, the little Toyota offers a variety of personalities. Both body styles feature a pair of dutiful four-cylinder engines, and they're also offered with an extremely frugal hybrid powertrain.",
                            descriptionShort = "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car.",
                            fuelTypeId = 1,
                            imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=2048:*",
                            imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=800:*",
                            isSpecialOffer = true,
                            name = "Toyota Corolla",
                            price = 21020m
                        });
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            description = "A sedan has four doors and a traditional trunk.",
                            name = "Sedan"
                        },
                        new
                        {
                            id = 2,
                            description = "Traditionally, the term hatchback has meant a compact or subcompact sedan with a squared-off roof and a rear flip-up hatch door that provides access to the vehicle's cargo area instead of a conventional trunk.",
                            name = "Hatchback"
                        },
                        new
                        {
                            id = 3,
                            description = "SUVs—often also referred to as crossovers—tend to be taller and boxier than sedans, offer an elevated seating position, and have more ground clearance than a car. ",
                            name = "SUV"
                        });
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.FuelType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("fuelTypes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            description = "Gasoline is the most common automobile fuel and is used all over the world to power cars, motorcycles, scooters, boats, lawnmowers, and other machinery.",
                            name = "Gasoline"
                        },
                        new
                        {
                            id = 2,
                            description = "Diesel fuel is also made from petroleum but is refined using a different method than that used to create gasoline.",
                            name = "Diesel"
                        },
                        new
                        {
                            id = 3,
                            description = "Diesel fuel that is created using vegetable oils or animal fats is called bio-diesel.",
                            name = "Bio-Diesel"
                        });
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("carid")
                        .HasColumnType("int");

                    b.Property<string>("shoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("carid");

                    b.ToTable("shoppingCartItems");
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Car", b =>
                {
                    b.HasOne("PolovniAutomobiliMVC.Models.Category", "category")
                        .WithMany("cars")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolovniAutomobiliMVC.Models.FuelType", "fuelType")
                        .WithMany()
                        .HasForeignKey("fuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("fuelType");
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("PolovniAutomobiliMVC.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Category", b =>
                {
                    b.Navigation("cars");
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PolovniAutomobiliMVC.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        // Konstruktor klase koji prima opcije baze podataka
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Definiranje tabela u bazi podataka
        public DbSet<Car> cars { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<FuelType> fuelTypes { get; set; }
        public DbSet<ShoppingCartItem> shoppingCartItems { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

        // Metoda koja se poziva prilikom konfiguriranja modela baze podataka
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dodavanje podataka o kategorijama
            modelBuilder.Entity<Category>().HasData(new Category { id = 1, name = "Sedan", description = "A sedan has four doors and a traditional trunk." });
            modelBuilder.Entity<Category>().HasData(new Category { id = 2, name = "Hatchback", description = "Traditionally, the term hatchback has meant a compact or subcompact sedan with a squared-off roof and a rear flip-up hatch door that provides access to the vehicle's cargo area instead of a conventional trunk." });
            modelBuilder.Entity<Category>().HasData(new Category { id = 3, name = "SUV", description = "SUVs—often also referred to as crossovers—tend to be taller and boxier than sedans, offer an elevated seating position, and have more ground clearance than a car. " });

            // Dodavanje podataka o vrstama goriva
            modelBuilder.Entity<FuelType>().HasData(new FuelType { id = 1, name = "Gasoline", description = "Gasoline is the most common automobile fuel and is used all over the world to power cars, motorcycles, scooters, boats, lawnmowers, and other machinery." });
            modelBuilder.Entity<FuelType>().HasData(new FuelType { id = 2, name = "Diesel", description = "Diesel fuel is also made from petroleum but is refined using a different method than that used to create gasoline." });
            modelBuilder.Entity<FuelType>().HasData(new FuelType { id = 3, name = "Bio-Diesel", description = "Diesel fuel that is created using vegetable oils or animal fats is called bio-diesel." });

            // Dodavanje podataka o automobilima
            modelBuilder.Entity<Car>().HasData(new Car
            {
                id = 1,
                name = "Hyundai Kona",
                description = "When an SUV delivers as crisp a driving experience as the 2022 Hyundai Kona, it's hard to get hung up on the usual anti-crossover sentiment—so we won't. The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position. Two four-cylinder engines are offered: a 2.0-liter four, which is admittedly pretty poky, and a more desirable turbocharged 1.6-liter four that delivers a lot more punch.",
                descriptionShort = "The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position.",
                imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=980:*",
                imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=980:*",
                isSpecialOffer = false,
                fuelTypeId = 1,
                price = 22135,
                categoryId = 3
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                id = 2,
                name = "Nissan Kicks",
                descriptionShort = "Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick.",
                description = "With a bold exterior look and a surprisingly spacious cabin, the 2021 Nissan Kicks is a stylish small SUV with a practical side. Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick. Standard equipment is plentiful and includes driver-assistance features and popular infotainment tech such as Apple CarPlay and Android Auto.",
                isSpecialOffer = true,
                fuelTypeId = 2,
                price = 20650,
                imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=2048:*",
                imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=800:*",
                categoryId = 3
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                id = 3,
                name = "VW Golf",
                descriptionShort = "Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. ",
                description = "Few compact hatchbacks are better than the 2021 Volkswagen Golf, but one that is happens to share the same showroom: the sporty GTI (reviewed separately). Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. While that's partly why VW will only offer the next-generation GTI and high-performance Golf R on our shores, it doesn't diminish that the regular version remains a terrific value in its final year.",
                isSpecialOffer = false,
                fuelTypeId = 1,
                price = 24190,
                imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=2048:*",
                imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=800:*",
                categoryId = 2
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                id = 4,
                name = "Ford Expedition",
                descriptionShort = "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. ",
                description = "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. It's available in both standard-length and long-wheelbase Expedition Max body styles and is powered by a twin-turbocharged V-6 engine with a 10-speed automatic transmission. Rear-wheel drive is standard, but buyers who need four-wheel action can have it on any trim level for a price.",
                isSpecialOffer = false,
                fuelTypeId = 2,
                price = 51690,
                imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=2048:*",
                imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=800:*",
                categoryId = 3
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                id = 5,
                name = "Kia Rio",
                descriptionShort = "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxes—but they're surprisingly more sophisticated than that.",
                description = "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxesS—but they're surprisingly more sophisticated than that. So much so that we named the Rio to our Editors' Choice list. The Kia couple shares a cabin design that exudes an elegant simplicity thanks to a smart layout and pleasing materials.",
                isSpecialOffer = true,
                fuelTypeId = 1,
                price = 17045,
                imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=2048:*",
                imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=800:*",
                categoryId = 2
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                id = 6,
                name = "Toyota Corolla",
                descriptionShort = "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car.",
                description = "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car. Available as either a four-door hatchback or sedan, the little Toyota offers a variety of personalities. Both body styles feature a pair of dutiful four-cylinder engines, and they're also offered with an extremely frugal hybrid powertrain.",
                isSpecialOffer = true,
                fuelTypeId = 1,
                price = 21020,
                imageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=2048:*",
                imageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=800:*",
                categoryId = 1
            });
        }
    }
}
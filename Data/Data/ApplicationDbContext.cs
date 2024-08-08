namespace CollectionCards.Data.Data
{
    using CollectionCards.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Card> Cards { get; set; }

       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Football", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Basketball", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Baseball", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Hockey", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Soccer", DisplayOrder = 5 }
                );
            modelBuilder.Entity<Organization>().HasData(
                new Organization { Id = 1, Name = "NBA", Street = "San Antonio 21", City = "New York", Country = "USA", PostalCode = "10001" },
                new Organization { Id = 2, Name = "NFL", Street = "Marge 3", City = "Boston", Country = "USA", PostalCode = "30001" },
                new Organization { Id = 3, Name = "MLB", Street = "Palm 5", City = "Los Angeles", Country = "USA", PostalCode = "20001" },
                new Organization { Id = 4, Name = "NHL", Street = "Pine 7", City = "Chicago", Country = "USA", PostalCode = "40001" }
                );
            modelBuilder.Entity<Card>().HasData(
                new Card
                {
                    Id = 1,
                    Title = "Baseball Card",
                    Description = "Mickey Mantle",
                    ImageUrl = "https://www.psacard.com/cardfacts/baseball-cards/1952-topps/mickey-mantle-311/23330",
                    Price = 12600000.00,
                    YearCard = 1952,
                    CategoryId = 3
                },
                new Card {Id=2,
                    Title="Basketball Card",
                     Description="Michael Jordan",
                     ImageUrl= "https://www.psacard.com/cardfacts/basketball-cards/1986-fleer/michael-jordan-57/27039",
                     Price=750000.00,
                     YearCard=1986,
                     CategoryId=2
                },
                new Card
                {
                    Id = 3,
                    Title = "Football Card",
                    Description = "Tom Brady",
                    ImageUrl = "https://www.psacard.com/cardfacts/football-cards/2000-playoff-contenders/tom-brady-144/27039",
                    Price = 250000.00,
                    YearCard = 2000,
                    CategoryId = 1
                },
                new Card
                {
                    Id=4,
                    Title="Baseball Card",
                    Description="Honus Wagner",
                    ImageUrl="https://www.psacard.com/cardfacts/baseball-cards/1909-11-t206/honus-wagner-175/27039",
                    Price=6600000.00,
                    YearCard=1909,
                    CategoryId=3
                },
                new Card
                {
                    Id=5,
                    Title="Basketball Card",
                    Description="Stephen Curry",
                    ImageUrl="https://www.psacard.com/cardfacts/basketball-cards/2009-10-panini-national-treasures/stephen-curry-206/27039",
                    Price=5900000.00,
                    YearCard=2009,
                    CategoryId=2
                }

                );
        }
    }
}

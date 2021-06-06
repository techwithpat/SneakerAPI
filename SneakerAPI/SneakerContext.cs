using Microsoft.EntityFrameworkCore;
using SneakerAPI.Models;
using System;

namespace SneakerAPI
{
    public class SneakerContext : DbContext
    {
        public SneakerContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sneaker>().HasData(
                new Sneaker 
                { 
                    Id = Guid.NewGuid(), 
                    Brand = "Nike", 
                    Name = "Air Force 1", 
                    ColorWay = "White", 
                    ReleaseYear = new DateTime(1982,1,1), 
                    Description = "Perhaps the most iconic Nike sneaker of all-time."
                },
                new Sneaker
                {
                    Id = Guid.NewGuid(),
                    Brand = "Adidas ",
                    Name = "Stan Smith",
                    ColorWay = "White",
                    ReleaseYear = new DateTime(1963, 1, 1),
                    Description = "The adidas Stan Smith tennis shoe design debuted in 1963 as the adidas Robert Haillet."
                });
        }

        public DbSet<Sneaker> Sneakers { get; set; }
    }
}

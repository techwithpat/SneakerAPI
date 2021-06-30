using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SneakerAPI.Models;
using System;

namespace SneakerAPI.Db
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedSneakers(modelBuilder);
            SeedUsers(modelBuilder);
            SeedRoles(modelBuilder);
            SeedUserRoles(modelBuilder);
        }

        private static void SeedSneakers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sneaker>().HasData(
                                new Sneaker
                                {
                                    Id = Guid.NewGuid(),
                                    Brand = "Nike",
                                    Name = "Air Force 1",
                                    ColorWay = "White",
                                    ReleaseYear = new DateTime(1982, 1, 1),
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
                                }
                            );
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var ph = new PasswordHasher<IdentityUser>();
            var user1 = new IdentityUser
            {
                Id = "1",
                UserName = "patrick",
                NormalizedUserName = "patrick".ToUpper(),
                Email = "patrick@fakemail.com",
                EmailConfirmed = true
            };
            user1.PasswordHash = ph.HashPassword(user1, "Patrick123");

            var user2 = new IdentityUser
            {
                Id = "2",
                UserName = "mike",
                NormalizedUserName = "mike".ToUpper(),
                Email = "mike@fakemail.Com",
                EmailConfirmed = true
            };
            user2.PasswordHash = ph.HashPassword(user2, "Mike123");

            modelBuilder.Entity<IdentityUser>().HasData(user1, user2);

        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "admin_role",
                    Name = "admin",
                    NormalizedName = "admin".ToUpper(),
                },
                new IdentityRole
                {
                    Id = "reader_role",
                    Name = "reader",
                    NormalizedName = "reader".ToUpper()
                }); 
        }

        private static void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "admin_role",
                    UserId = "1"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "reader_role",
                    UserId = "2"
                });
        }
    }
}

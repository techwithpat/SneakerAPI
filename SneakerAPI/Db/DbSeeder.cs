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
                Id = "029976c6-5457-488c-ad46-675e626ef00d",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com".ToUpper(),
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };
            user1.PasswordHash = ph.HashPassword(user1, "admin123");

            var user2 = new IdentityUser
            {
                Id = "0cb46b1c-3452-4194-ae9d-1b086c135017",
                UserName = "reader@gmail.com",
                NormalizedUserName = "reader@gmail.com".ToUpper(),
                EmailConfirmed = true
            };
            user2.PasswordHash = ph.HashPassword(user2, "reader123");

            modelBuilder.Entity<IdentityUser>().HasData(
                    user1, user2
                );
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                 new IdentityRole
                 {
                     Id = "admin_role",
                     Name = "admin",
                     NormalizedName = "admin".ToUpper()
                 },
                 new IdentityRole
                 {
                     Id= "reader_role",
                     Name = "reader",
                     NormalizedName = "reader".ToUpper()
                 }
                );
        }

        private static void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "admin_role",
                        UserId = "029976c6-5457-488c-ad46-675e626ef00d"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "reader_role",
                        UserId = "0cb46b1c-3452-4194-ae9d-1b086c135017"
                    }
                );
        }
    }
}

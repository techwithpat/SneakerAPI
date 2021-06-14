using Microsoft.EntityFrameworkCore;
using SneakerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerAPI.Db
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sneaker>().HasData(
                    new Sneaker
                    {

                    }
                );
        }
    }
}

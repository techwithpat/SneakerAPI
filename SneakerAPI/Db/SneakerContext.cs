using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SneakerAPI.Models;

namespace SneakerAPI.Db
{
    public class SneakerContext : IdentityDbContext<IdentityUser>
    {
        public SneakerContext(DbContextOptions<SneakerContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }

        public DbSet<Sneaker> Sneakers { get; set; }
    }
}

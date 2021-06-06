using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SneakerAPI.Repositories;

namespace SneakerAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<ISneakerRepository, SneakerRepository>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SneakerContext>(
                o => o.UseSqlServer(configuration.GetConnectionString("SqlConnection"),
                b => b.MigrationsAssembly("SneakerAPI")));
        }
    }
}

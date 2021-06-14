using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SneakerAPI.Db
{
    public static class DbExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SneakerContext>(
                o => o.UseSqlServer(configuration.GetConnectionString("SqlConnection"),
                b => b.MigrationsAssembly("SneakerAPI")));
        }
    }
}

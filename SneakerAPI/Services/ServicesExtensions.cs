using Microsoft.Extensions.DependencyInjection;
using SneakerAPI.Services;

namespace SneakerAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ISneakerService, SneakerService>();
        }                 
    }
}

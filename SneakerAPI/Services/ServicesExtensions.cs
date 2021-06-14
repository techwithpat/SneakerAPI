using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SneakerAPI.Db;
using SneakerAPI.Services;

namespace SneakerAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ISneakerService, SneakerService>();
            services.AddTransient<IAuthenticationManager, AuthenticationManager>();
        }   
        
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentityCore<IdentityUser>(o => 
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequireUppercase = false;
                o.User.RequireUniqueEmail = true;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<SneakerContext>()
            .AddDefaultTokenProviders();
        }
    }
}

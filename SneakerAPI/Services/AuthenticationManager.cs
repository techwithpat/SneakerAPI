using Microsoft.AspNetCore.Identity;
using SneakerAPI.Models;
using System.Threading.Tasks;

namespace SneakerAPI.Services
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationManager(UserManager<IdentityUser> userManager) => _userManager = userManager;

        public async Task<bool> ValidateCredentials(AuthCredentials credentials)
        {
            var user = await _userManager.FindByNameAsync(credentials.Username);
            return user != null && await _userManager.CheckPasswordAsync(user, credentials.Password);
        }
    }
}

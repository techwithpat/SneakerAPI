using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SneakerAPI.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SneakerAPI.Services
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private IdentityUser _user;

        public AuthenticationManager(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<bool> ValidateCredentials(AuthCredentials credentials)
        {
            _user = await _userManager.FindByNameAsync(credentials.Username);
            return _user != null && await _userManager.CheckPasswordAsync(_user, credentials.Password);
        }

        public async Task<string> CreateToken()
        {
            var jwtsettings = _configuration.GetSection("JwtSettings");

            var claims = await GetClaims();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtsettings.GetSection("secret").Value));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtsettings.GetSection("validIssuer").Value,
                audience: jwtsettings.GetSection("validAudience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            { new Claim(ClaimTypes.Name, _user.UserName) };

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
    }
}

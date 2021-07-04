using SneakerAPI.Models;
using System.Threading.Tasks;

namespace SneakerAPI.Services
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateCredentials(AuthCredentials credentials);
        Task<string> CreateToken();
    }
}

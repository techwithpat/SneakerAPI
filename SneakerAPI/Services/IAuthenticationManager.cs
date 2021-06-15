using SneakerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerAPI.Services
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateCredentials(AuthCredentials credentials);
    }
}

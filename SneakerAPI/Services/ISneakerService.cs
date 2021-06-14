using SneakerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SneakerAPI.Services
{
    public interface ISneakerService
    {
        IEnumerable<Sneaker> GetAll();
        Task Create(Sneaker sneaker);
    }
}

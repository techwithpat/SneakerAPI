using SneakerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SneakerAPI.Repositories
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> GetAll();
        Task Create(Sneaker sneaker);
        Task Delete(Sneaker sneaker);
    }
}

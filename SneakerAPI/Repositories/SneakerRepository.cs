using SneakerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SneakerAPI.Repositories
{
    public class SneakerRepository : ISneakerRepository
    {
        private readonly SneakerContext _sneakerContext;

        public SneakerRepository(SneakerContext sneakerContext)
        {
            _sneakerContext = sneakerContext;
        }

        public IEnumerable<Sneaker> GetAll()
        {
            return _sneakerContext.Set<Sneaker>();
        }

        public Task Create(Sneaker sneaker)
        {
            _sneakerContext.Set<Sneaker>().Add(sneaker);
            return _sneakerContext.SaveChangesAsync();
        }

        public Task Delete(Sneaker sneaker)
        {
            _sneakerContext.Set<Sneaker>().Remove(sneaker);
            return _sneakerContext.SaveChangesAsync();
        }
    }
}

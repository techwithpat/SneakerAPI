using SneakerAPI.Models;
using System;
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
            sneaker.Id = Guid.NewGuid();
            _sneakerContext.Set<Sneaker>().AddAsync(sneaker);
            return _sneakerContext.SaveChangesAsync();
        }
    }
}

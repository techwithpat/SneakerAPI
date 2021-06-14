using SneakerAPI.Db;
using SneakerAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SneakerAPI.Services
{
    public class SneakerService : ISneakerService
    {
        private readonly SneakerContext _sneakerContext;

        public SneakerService(SneakerContext sneakerContext)
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

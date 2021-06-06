using Microsoft.AspNetCore.Mvc;
using SneakerAPI.Models;
using SneakerAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SneakerAPI.Controllers
{
    [Route("api/sneakers")]
    [ApiController]
    public class SneakerController : ControllerBase
    {
        private readonly ISneakerRepository _sneakerRepository;

        public SneakerController(ISneakerRepository sneakerRepository) 
            => _sneakerRepository = sneakerRepository;

        [HttpGet]
        public IEnumerable<Sneaker> Get()
        {
            return _sneakerRepository.GetAll();
        }
               
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Sneaker sneaker)
        {
            await _sneakerRepository.Create(sneaker);
            return StatusCode(201);
        }
    }
}

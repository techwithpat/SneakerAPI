using Microsoft.AspNetCore.Mvc;
using SneakerAPI.Models;
using SneakerAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SneakerAPI.Controllers
{
    [Route("api/sneakers")]
    [ApiController]
    public class SneakerController : ControllerBase
    {
        private readonly ISneakerService _sneakerRepository;

        public SneakerController(ISneakerService sneakerRepository) 
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

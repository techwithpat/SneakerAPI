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
        private readonly ISneakerService _sneakerService;

        public SneakerController(ISneakerService sneakerRepository) 
            => _sneakerService = sneakerRepository;

        [HttpGet]
        public IEnumerable<Sneaker> Get()
        {
            return _sneakerService.GetAll();
        }
               
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Sneaker sneaker)
        {
            await _sneakerService.Create(sneaker);
            return StatusCode(201);
        }
    }
}

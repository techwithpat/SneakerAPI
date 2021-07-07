using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SneakerAPI.Models;
using SneakerAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SneakerAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/sneakers")]
    [ApiController]
    public class SneakerController : ControllerBase
    {
        private readonly ISneakerService _sneakerService;

        public SneakerController(ISneakerService sneakerService) 
            => _sneakerService = sneakerService;

        /// <summary>
        /// Returns a list of sneakers
        /// </summary>
        /// <returns> A list of sneakers</returns>
        /// <remarks>
        /// 
        /// Sample request
        /// GET /api/sneakers
        /// 
        /// </remarks>
        /// <response code="200">Returns a list of sneakers</response>
        [HttpGet, Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public IEnumerable<Sneaker> Get() => _sneakerService.GetAll();

        /// <summary>
        /// Create a new sneaker
        /// </summary>
        /// <param name="sneaker">Request's payload</param>
        /// <returns></returns>
        /// <response code="201">Sneaker created successfully</response>
        [HttpPost, Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Post([FromBody] Sneaker sneaker)
        {
            await _sneakerService.Create(sneaker);
            return StatusCode(201);
        }
    }
}

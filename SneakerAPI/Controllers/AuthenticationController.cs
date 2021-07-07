using Microsoft.AspNetCore.Mvc;
using SneakerAPI.Models;
using SneakerAPI.Services;
using System.Threading.Tasks;

namespace SneakerAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationManager _authenticationManager;

        public AuthenticationController(IAuthenticationManager authenticationService)
        {
            _authenticationManager = authenticationService;
        }

        /// <summary>
        /// Request a token
        /// </summary>
        /// <param name="credentials"></param>
        /// <returns></returns>
        [HttpPost("login")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Post))]
        public async Task<IActionResult> Login([FromBody] AuthCredentials credentials)
        {
            if(!ModelState.IsValid)            
               return BadRequest();            

            if (!await _authenticationManager.ValidateCredentials(credentials))
                return Unauthorized();

            return Ok(new { Token = _authenticationManager.CreateToken() });
        }
    }
}

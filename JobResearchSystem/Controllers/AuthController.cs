using JobResearchSystem.Application.DTOs.Authentication;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities.Extend;
using Microsoft.AspNetCore.Mvc;


namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ApiBaseController
    {

        #region CTOR
        //private ResponseDto _response;
        private readonly IAuthService _authService;

        public AuthController(IAuthService _authService)
        {
            //_response = new ResponseDto();
            this._authService = _authService;
        }
        #endregion

        [HttpPost]
        [Route("seed-roles")]
        public async Task<IActionResult> SeedRoles()
        {
            var seerRoles = await _authService.SeedRolesAsync();

            return Ok(seerRoles);
        }


        // Route -> Register
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }


        // Route -> Login
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.LoginAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.GetAllUsersAsync();

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] string id)
        {
            var result = await _authService.DeleteUserAsync(id);

            if (!result) return BadRequest();

            return NoContent();
        }

        [HttpGet]
        [Route("GetUserById")]
        public async Task<IActionResult> GetUserById([FromQuery] string Id)
        {
            var result = await _authService.GetUserByIdAsync(Id);

            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDetailsDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.UpdateUserAsync(model);

            if(result is null) return BadRequest("user not found!");

            return Ok(result);
        }


    }
}

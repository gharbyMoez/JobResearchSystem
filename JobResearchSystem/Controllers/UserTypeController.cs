using JobResearchSystem.Application.Feature.UserTypes.Commands.Models;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ApiBaseController
    {


        [HttpGet("GetAllUserTypes")]
        public async Task<IActionResult> GetAllUserTypes()
        {
            var result = await Mediator.Send(new GetAllUserTypesQuery());
            return NewResult(result);
        }

        [HttpGet("GetUserTypeById")]
        public async Task<IActionResult> GetUserTypeById([FromQuery] GetUserTypeByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpPost("AddUserType")]
        public async Task<IActionResult> AddUserType(AddUserTypeCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateUserType")]
        public async Task<IActionResult> UpdateUserType(UpdateUserTypeCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveUserType")]
        public async Task<IActionResult> RemoveUserType(DeleteUserTypeCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

    }
}

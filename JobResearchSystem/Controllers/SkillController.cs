using JobResearchSystem.Application.Feature.Skills.Commands.Models;
using JobResearchSystem.Application.Feature.Skills.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        #region CTOR
        private readonly IMediator _mediator;

        public SkillController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        [HttpGet("GetAllSkills")]
        public async Task<IActionResult> GetAllSkills()
        {
            var result = await _mediator.Send(new GetAllSkillsQuery());
            return Ok(result);
        }

        [HttpGet("GetSkillById")]
        public async Task<IActionResult> GetSkillById([FromQuery] GetSkillByIdQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                // Handle not found
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("AddSkill")]
        public async Task<IActionResult> AddSkill(AddSkillCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateSkill")]
        public async Task<IActionResult> UpdateSkill(UpdateSkillCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("RemoveSkill")]
        public async Task<IActionResult> RemoveSkill(DeleteSkillCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}

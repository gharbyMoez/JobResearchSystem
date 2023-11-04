using JobResearchSystem.Application.Feature.Skills.Commands.Models;
using JobResearchSystem.Application.Feature.Skills.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ApiBaseController
    {


        [HttpGet("GetAllSkills")]
        public async Task<IActionResult> GetAllSkills()
        {
            var result = await Mediator.Send(new GetAllSkillsQuery());
            return NewResult(result);
        }

        [HttpGet("GetAllSkillsByJobSeekerId")]
        public async Task<IActionResult> GetAllSkillsByJobSeekerId([FromQuery] GetAllSkillsByJobSeekerIdQuery query)
        {
            var result = await Mediator.Send(query);
            return NewResult(result);
        }

        [HttpGet("GetSkillById")]
        public async Task<IActionResult> GetSkillById([FromQuery] GetSkillByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpPost("AddSkill")]
        public async Task<IActionResult> AddSkill(AddSkillCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateSkill")]
        public async Task<IActionResult> UpdateSkill(UpdateSkillCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveSkill")]
        public async Task<IActionResult> RemoveSkill(DeleteSkillCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

    }
}

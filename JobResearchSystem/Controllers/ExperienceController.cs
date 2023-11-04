using JobResearchSystem.Application.Feature.Experiences.Commands.Models;
using JobResearchSystem.Application.Feature.Experiences.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ApiBaseController
    {


        [HttpGet("GetAllExperiences")]
        public async Task<IActionResult> GetAllExperiences()
        {
            var result = await Mediator.Send(new GetAllExperiencesQuery());
            return NewResult(result);
        }

        [HttpGet("GetExperienceById")]
        public async Task<IActionResult> GetExperienceById([FromQuery] GetExperienceByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpGet("GetAllExperiencesByJobSeekerId")]
        public async Task<IActionResult> GetAllExperiencesByJobSeekerId([FromQuery] GetAllExperiencesByJobSeekerIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpPost("AddExperience")]
        public async Task<IActionResult> AddExperience(AddExperienceCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateExperience")]
        public async Task<IActionResult> UpdateExperience(UpdateExperienceCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveExperience")]
        public async Task<IActionResult> RemoveExperience(DeleteExperienceCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

    }
}

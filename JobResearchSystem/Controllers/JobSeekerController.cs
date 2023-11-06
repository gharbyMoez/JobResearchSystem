using JobResearchSystem.Application.Feature.JobSeekers.Commands.Models;
using JobResearchSystem.Application.Feature.JobSeekers.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ApiBaseController
    {
        [HttpGet("GetAllJobSeekers")]
        public async Task<IActionResult> GetAllJobSeekers()
        {
            var result = await Mediator.Send(new GetAllJobSeekersQuery());
            return NewResult(result);
        }

        [HttpGet("GetJobSeekerByUserId")]
        public async Task<IActionResult> GetJobSeekerByUserId([FromQuery] GetJobSeekerByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpPost("AddJobSeeker")]
        public async Task<IActionResult> AddJobSeeker([FromForm] AddJobSeekerCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateJobSeeker")]
        public async Task<IActionResult> UpdateJobSeeker([FromForm] UpdateJobSeekerCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveJobSeeker")]
        public async Task<IActionResult> RemoveJobSeeker(DeleteJobSeekerCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

    }
}

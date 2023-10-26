using JobResearchSystem.Application.Feature.Jobs.Commands.Models;
using JobResearchSystem.Application.Feature.Jobs.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        #region CTOR
        private readonly IMediator _mediator;

        public JobController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        [HttpGet("GetAllJobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            var result = await _mediator.Send(new GetAllJobsQuery());
            return Ok(result);
        }

        [HttpGet("GetJobById")]
        public async Task<IActionResult> GetJobById([FromQuery] GetJobByIdQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                // Handle not found
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("AddJob")]
        public async Task<IActionResult> AddJob(AddJobCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateJob")]
        public async Task<IActionResult> UpdateJob(UpdateJobCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("RemoveJob")]
        public async Task<IActionResult> RemoveJob(DeleteJobCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}

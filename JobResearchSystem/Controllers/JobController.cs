using JobResearchSystem.Application.Feature.Jobs.Commands.Models;
using JobResearchSystem.Application.Feature.Jobs.Queries.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ApiBaseController
    {


        [HttpGet("GetAllJobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            var result = await Mediator.Send(new GetAllJobsQuery());
            return NewResult(result);
        }

        [HttpGet("GetJobById")]
        public async Task<IActionResult> GetJobById([FromQuery] GetJobByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [Authorize(Roles = "COMPANY")]
        [HttpPost("AddJob")]
        public async Task<IActionResult> AddJob(AddJobCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [Authorize(Roles = "COMPANY")]
        [HttpPut("UpdateJob")]
        public async Task<IActionResult> UpdateJob(UpdateJobCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [Authorize(Roles = "COMPANY")]
        [HttpDelete("RemoveJob")]
        public async Task<IActionResult> RemoveJob(DeleteJobCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }
        
        
        [HttpGet("{jobId}/applicant")]
        public async Task<IActionResult> GetAllApplicantByJobId(int jobId)
        {
            var result = await Mediator.Send(new GetAllApplicantByJobIdQuery() { JobId = jobId});

            return NewResult(result);
        }




    }
}

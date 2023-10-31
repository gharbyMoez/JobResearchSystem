using JobResearchSystem.Application.Feature.Applicants.Commands.Models;
using JobResearchSystem.Application.Feature.Applicants.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ApiBaseController
    {

        [HttpGet("GetAllApplicants")]
        public async Task<IActionResult> GetAllApplicants()
        {
            var result = await Mediator.Send(new GetAllApplicantsQuery());
            return NewResult(result);
        }

        [HttpGet("GetApplicantById")]
        public async Task<IActionResult> GetApplicantById([FromQuery] GetApplicantByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpPost("AddApplicant")]
        public async Task<IActionResult> AddApplicant(AddApplicantCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateApplicant")]
        public async Task<IActionResult> UpdateApplicant(UpdateApplicantCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveApplicant")]
        public async Task<IActionResult> RemoveApplicant(DeleteApplicantCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }
    }
}

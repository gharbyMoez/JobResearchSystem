using JobResearchSystem.Application.Feature.Experiences.Queries.Models;
using JobResearchSystem.Application.Feature.Qualifications.Commands.Models;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobResearchSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualificationController : ApiBaseController
    {


        [HttpGet("GetAllQualifications")]
        public async Task<IActionResult> GetAllQualifications()
        {
            var result = await Mediator.Send(new GetAllQualificationsQuery());
            return NewResult(result);
        }

        [HttpGet("GetQualificationById")]
        public async Task<IActionResult> GetQualificationById([FromQuery] GetQualificationByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpGet("GetAllQualificationByJobseekerId")]
        public async Task<IActionResult> GetAllQualificationByJobseekerId([FromQuery] GetAllQualificationByJobseekerIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        [HttpPost("AddQualification")]
        public async Task<IActionResult> AddQualification(AddQualificationCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateQualification")]
        public async Task<IActionResult> UpdateQualification(UpdateQualificationCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveQualification")]
        public async Task<IActionResult> RemoveQualification(DeleteQualificationCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

    }
}

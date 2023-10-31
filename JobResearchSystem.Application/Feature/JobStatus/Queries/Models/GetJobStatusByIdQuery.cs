using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.JobStatus.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.JobStatus.Queries.Models
{
    public class GetJobStatusByIdQuery : IRequest<Response<GetJobStatusResponse>>
    {
        public int SkillId { get; set; }
    }
}

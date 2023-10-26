using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Queries.Models
{
    public class GetJobByIdQuery : IRequest<Response<GetJobResponse>>
    {
        public int SkillId { get; set; }
    }
}

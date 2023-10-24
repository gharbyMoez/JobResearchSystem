using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Queries.Models
{
    public class GetSkillByIdQuery : IRequest<Response<GetSkillResponse>>
    {
        public int SkillId { get; set; }
    }
}

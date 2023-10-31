using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Queries.Models
{
    public class GetAllSkillsQuery : IRequest<Response<IEnumerable<GetSkillResponse>>>
    {
    }
}

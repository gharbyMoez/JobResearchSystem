using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Queries.Models
{
    public class GetAllSkillsByJobSeekerIdQuery : IRequest<Response<IEnumerable<GetSkillResponse>>>
    {
        public int JobSeekerId { get; set; }
    }
}

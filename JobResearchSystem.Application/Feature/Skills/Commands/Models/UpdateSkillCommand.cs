using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Commands.Models
{
    public class UpdateSkillCommand : IRequest<Response<GetSkillResponse>>
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
    }
}

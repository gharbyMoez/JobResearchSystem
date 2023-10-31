using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Commands.Models
{
    public class DeleteSkillCommand : IRequest<Response<string>>
    {
        public int SkillId { get; set; }
    }
}

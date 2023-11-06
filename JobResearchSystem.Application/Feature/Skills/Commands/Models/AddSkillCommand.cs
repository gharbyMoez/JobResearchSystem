using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Skills.Commands.Models
{
    public class AddSkillCommand : IRequest<Response<string>>
    {
        public string SkillName { get; set; }
        public int JobSeekerId { get; set; }
    }
}

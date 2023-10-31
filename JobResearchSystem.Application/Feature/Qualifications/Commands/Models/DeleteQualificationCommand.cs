using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Models
{
    public class DeleteQualificationCommand : IRequest<Response<string>>
    {
        public int ExperienceId { get; set; }
    }
}

using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Models
{
    public class AddExperienceCommand : IRequest<Response<string>>
    {
        public string ExperienceCompanyName { get; set; }

        public string ExperienceTitle { get; set; }

        public DateTime? ExperienceStartDate { get; set; }
        public DateTime? ExperienceEndDate { get; set; }

        public string? PositionDescription { get; set; }

        /*----- Relations -----*/

        public int JobSeekerId { get; set; }
    }
}

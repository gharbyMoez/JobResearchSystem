using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Models
{
    public class UpdateQualificationCommand : IRequest<Response<GetQualificationResponse>>
    {
        public int ExperienceId { get; set; }
        public string ExperienceCompanyName { get; set; }

        public string ExperienceTitle { get; set; }

        public DateTime? ExperienceStartDate { get; set; }
        public DateTime? ExperienceEndDate { get; set; }

        public string? PositionDescription { get; set; }

        /*----- Relations -----*/

        public int JobSeekerId { get; set; }
    }
}

using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Experiences.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Commands.Models
{
    public class UpdateExperienceCommand : IRequest<Response<GetExperienceResponse>>
    {
        public int Id { get; set; }
        public string ExperienceCompanyName { get; set; }

        public string ExperienceTitle { get; set; }

        public DateTime? ExperienceStartDate { get; set; }
        public DateTime? ExperienceEndDate { get; set; }

        public string? PositionDescription { get; set; }

        /*----- Relations -----*/

        //public int JobSeekerId { get; set; }
    }
}

using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Qualifications.Commands.Models
{
    public class AddQualificationCommand : IRequest<Response<string>>
    {
        public string SchoolName { get; set; }
        public string? Degree { get; set; }
        public string? FieldOfStudy { get; set; }
        public decimal? Duration { get; set; }
        public DateTime? QualificationStartDate { get; set; }
        public DateTime? QualificationEndDate { get; set; }

        public decimal? Grade { get; set; }
        public string? QualificationDescription { get; set; }

        /*----- Relations -----*/

        public int JobSeekerId { get; set; }

    }
}

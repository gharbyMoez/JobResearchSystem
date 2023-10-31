using JobResearchSystem.Application.Bases;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Commands.Models
{
    public class AddApplicantCommand : IRequest<Response<string>>
    {
        public int JobSeekerId { get; set; }
        public int JobId { get; set; }
        //public int ApplicantStatusId { get; set; }

    }
}

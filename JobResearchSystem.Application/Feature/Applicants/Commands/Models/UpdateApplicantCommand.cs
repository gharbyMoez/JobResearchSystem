using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Commands.Models
{
    public class UpdateApplicantCommand : IRequest<Response<GetApplicantResponse>>
    {
        public int Id { get; set; }

        public int JobId { get; set; }
        public int JobSeekerId { get; set; }
        public int ApplicantStatusId { get; set; }
    }
}

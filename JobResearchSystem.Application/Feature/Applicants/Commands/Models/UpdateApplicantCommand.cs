using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Commands.Models
{
    public class UpdateApplicantCommand : IRequest<Response<GetApplicantResponse>>
    {
        public int ApplicantId { get; set; }
        public int ApplicantStatusId { get; set; }
    }
}

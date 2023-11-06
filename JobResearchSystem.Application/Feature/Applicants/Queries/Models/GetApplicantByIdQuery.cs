using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Queries.Models
{
    public class GetApplicantByIdQuery : IRequest<Response<GetApplicantResponse>>
    {
        public int ApplicantId { get; set; }
    }
}

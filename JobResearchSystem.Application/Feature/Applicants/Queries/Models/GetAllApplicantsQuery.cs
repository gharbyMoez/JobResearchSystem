using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Applicants.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Applicants.Queries.Models
{
    public class GetAllApplicantsQuery : IRequest<Response<IEnumerable<GetApplicantResponse>>>
    {
    }
}

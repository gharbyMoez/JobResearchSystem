using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.ApplicantStatus.Queries.Models
{
    public class GetAllApplicantStatusesQuery : IRequest<Response<IEnumerable<GetApplicantStatusResponse>>>
    {
    }
}

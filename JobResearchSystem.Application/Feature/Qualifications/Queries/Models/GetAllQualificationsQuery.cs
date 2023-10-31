using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Qualifications.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Experiences.Queries.Models
{
    public class GetAllQualificationsQuery : IRequest<Response<IEnumerable<GetQualificationResponse>>>
    {
    }
}

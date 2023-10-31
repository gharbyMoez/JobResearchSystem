using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.UserTypes.Queries.Models
{
    public class GetAllUserTypesQuery : IRequest<Response<IEnumerable<GetUserTypeResponse>>>
    {
    }
}

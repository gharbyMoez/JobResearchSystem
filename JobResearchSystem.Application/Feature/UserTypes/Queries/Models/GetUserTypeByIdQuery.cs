using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.UserTypes.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.UserTypes.Queries.Models
{
    public class GetUserTypeByIdQuery : IRequest<Response<GetUserTypeResponse>>
    {
        public int UserTypeId { get; set; }
    }
}

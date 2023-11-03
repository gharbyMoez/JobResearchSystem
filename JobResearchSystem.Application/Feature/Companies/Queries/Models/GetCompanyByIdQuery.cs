using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Companies.Queries.Responses;
using JobResearchSystem.Application.Feature.Skills.Queries.Response;
using MediatR;

namespace JobResearchSystem.Application.Feature.Companies.Queries.Models
{
    public class GetCompanyByIdQuery : IRequest<Response<GetCompanyResponse>>
    {
        public string UserId { get; set; }
    }
}

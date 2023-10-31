using JobResearchSystem.Application.Bases;
using JobResearchSystem.Application.Feature.Companies.Queries.Responses;
using MediatR;

namespace JobResearchSystem.Application.Feature.Companies.Queries.Models
{
    public class GetAllCompaniesQuery : IRequest<Response<IEnumerable<GetCompanyResponse>>>
    {
    }
}
